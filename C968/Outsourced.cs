namespace C968
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string cn)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inStock;
            Min = min;
            Max = max;
            CompanyName = cn;
        }
    }


}
