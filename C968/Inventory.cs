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
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static int GeneratePartID()
        {
            return uniquePartID++; //starts with 1001 and then increments
        }
        public void addProduct(Product product)
        {
            
        }

        public bool removeProduct(int id)
        {
            return true; //change later
        }

        public Product lookupProduct(int id)
        {
            //add later
            return Products[id];
        }

        public void updateProduct(int id, Product product)
        {
                //add later
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
            
        }

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

        public Part lookupPart(int id)
        { 
            //add later
            return AllParts[id];
        }

        public void updatePart(int id, Part part)
        {
            //add later
        }


    }
}
