namespace C968
{
    public partial class Main_Form : Form
    {
        public Inventory Inventory { get; set; } = new Inventory();
        public Main_Form()
        {
            InitializeComponent();
            dg_parts.DataSource = Inventory.AllParts;
            dg_products.DataSource = Inventory.Products;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_parts_add_Click(object sender, EventArgs e)
        {
            Add_Part addForm = new()
            {
                Inventory = this.Inventory // Pass the Inventory instance to Add_Part
            };
            addForm.Show();
        }

        private void btn_parts_modify_Click(object sender, EventArgs e)
        {
            Modify_Part modifyPart = new();
            modifyPart.Show();
        }
    }
}
