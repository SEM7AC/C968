using System.Runtime.CompilerServices;

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

            if (dg_parts.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_parts.SelectedRows[0].Index;
                Part selectedPart = dg_parts.Rows[selectedIndex].DataBoundItem as Part;
                                
                Modify_Part modifyPart = new Modify_Part(selectedPart)
                {
                    Inventory = this.Inventory
                };

                modifyPart.Show();

                // Optionally, refresh the DataGridView to reflect any changes made
                dg_parts.Refresh();



            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }

            
        }

        private void btn_parts_delete_Click(object sender, EventArgs e)
        {
            if (dg_parts.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_parts.SelectedRows[0].Index;
                Part selectedPart = dg_parts.Rows[selectedIndex].DataBoundItem as Part;


                if (selectedPart != null)
                {
                    int id = selectedPart.PartID;
                    if (Inventory.deletePart(id))// Call your DeletePart function and check if it returns true
                    {
                        MessageBox.Show("Part deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the part.");
                    }
                }
            }

            else 
            { 
                MessageBox.Show("Please select a part to delete.");
            }
            

        }

        // This will capture which part ID is selected when the user highlights a part
        // Will need to pass the ID to the delete and modify part functions....
        private void dg_parts_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
