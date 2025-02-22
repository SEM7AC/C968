namespace C968
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
