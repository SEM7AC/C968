using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Inventory
    {
        private static int uniquePartID = 1001; //Unique Part ID counter
        private static int uniqueProductID = 5001; //Unique Product ID counter
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();


        //Method to increment partID when adding a part to inventory
        public static int GeneratePartID()
        {
            return uniquePartID++; 
        }

        //Method to increment productID when adding a product to inventory
        public static int GenerateProductID()
        {
            return uniqueProductID++;
        }

        //Method for adding a product
        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        //NOT IMPLEMENTED YET *******************************************
        public bool removeProduct(int id)
        {
            return true; //change later
        }

        //NOT IMPLEMENTED YET *******************************************
        public Product lookupProduct(int id)
        {
            //add later
            return Products[id];
        }

        //NOT IMPLEMENTED YET *******************************************
        public void updateProduct(int id, Product product)
        {
            //add later
        }

        
        //Method for adding a part to AllParts
        public void addPart(Part part)
        {
            AllParts.Add(part);

        }
               
        
        //Method for deleting a part from AllParts
        public bool deletePart(int id)
        {
            var part = AllParts.FirstOrDefault(p => p.PartID == id);
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        //NOT IMPLEMENTED YET *******************************************
        public Part lookupPart(int id)
        {
            //add later
            return AllParts[id];
        }

        //Method used by the modify_part form. Find the part in AllParts using partID
        //gets the index of the part and then replaces part at that index with modified
        //part information
        public void updatePart(int id, Part updatedPart)
        {
            
            var existingPart = AllParts.FirstOrDefault(p => p.PartID == id);
            if (existingPart != null)
            {
                int index = AllParts.IndexOf(existingPart); //gets index of part
                AllParts[index] = updatedPart; //replaces modified part info.
            }
        }

        //adding specific functions for inhouse and outsourced parts. Still uses add part but moved logic away
        //from add_part form

        public void addInhousePart(int partID, string name, decimal price, int inventory, int min, int max, int machineID)
        {
            
            Part part = new Inhouse(partID, name, price, inventory, min, max, machineID);
            addPart(part);
        }

        public void addOutsourcedPart(int partID, string name, decimal price, int inventory, int min, int max, string companyName)
        {
            
            Part part = new Outsourced(partID, name, price, inventory, min, max, companyName);
            addPart(part);


        }
    }
}
