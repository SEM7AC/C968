using System.ComponentModel;

namespace C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();   

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int id)
        {
            return true; //change this later
        }

        public Part lookupAssociatedPart(int id)

        { 
            //add later
            return AssociatedParts[id];
        }
    }
}
