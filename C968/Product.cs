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

        //Method to add part to associated parts
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //Method to remove associated part from product returns bool
        public bool removeAssociatedPart(int id)
        {
            var removePart = lookupAssociatedPart(id);
            if (removePart != null)
            {
                AssociatedParts.Remove(removePart);
                return true;
            }
            return false;

        }
        //Method for returning a part with the id parameter. Helps with remove/modify
        public Part lookupAssociatedPart(int id)

        {
            var lookupAssociatedPart = AssociatedParts.FirstOrDefault(p => p.PartID == id);
            if (lookupAssociatedPart == null)
            {
                MessageBox.Show("Part doesn't exist");
            }
            return lookupAssociatedPart;

        }

    }
}
