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
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public void addProduct(Product)
        {
            //add later
        }

        public bool removeProduct(int id)
        {
            //add later
        }

        public Product lookupProduct(int id)
        {
            //add later
        }

        public void updateProduct(int id, Product)
        {
                //add later
        }

        public void addPart()
        {
            //add later
        }

        public bool deletePart(int id)
        { 
            //add later
        }

        public Part lookupPart(int id)
        { 
            //add later
        }

        public void updatePart(int id, Part)
        {
            //add later
        }


    }
}
