using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Instock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public void addAssociatedPart(Part)
        {
            //add later
        }

        public bool removeAssociatedPart(int id)
        {
            //add later
        }

        public Part lookupAssociatedPart(int id)
        { 
            //add later
        }
    }
}
