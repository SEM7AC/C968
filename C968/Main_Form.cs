using System.Diagnostics.Eventing.Reader;

namespace C968
{
    public partial class Main_Form : Form
    {

        public Inventory Inventory { get; set; } = new Inventory(); //creates instance of inventory


        public Main_Form()
        {
            InitializeComponent();
            
            startup_helper();

            dg_parts.DataSource = Inventory.AllParts; //datagrid bindings
            dg_products.DataSource = Inventory.Products;

            dg_parts.ClearSelection();
            dg_products.ClearSelection();
           


        }
        //Preload the inventory with some parts and products... got tired of typing this in everytime I was testing.
        public void startup_helper()
        {
            Part part1 = new Inhouse(Inventory.GeneratePartID(), "Bolt", 5.00m, 100, 5, 150, 64 );
            Part part2 = new Inhouse(Inventory.GeneratePartID(), "Washer", 0.10m, 100, 5, 150, 75);
            Part part3 = new Outsourced(Inventory.GeneratePartID(), "Nut", 2.00m, 100, 5, 150, "Big Dave's LLC");
            Part part4 = new Outsourced(Inventory.GeneratePartID(), "Lever", 2700.00m, 5, 1, 10, "Larry's Levers");
            Inventory.addPart(part1);
            Inventory.addPart(part2);
            Inventory.addPart(part3);
            Inventory.addPart(part4);

            Product product1 = new Product
            {
                ProductID = Inventory.GenerateProductID(),
                Name = "AS350B3 Astar",
                Price = 1900000.00m,
                Inventory = 5,
                Min = 1,
                Max = 10
                
            };

            product1.addAssociatedPart(part1);
            product1.addAssociatedPart(part2);
            product1.addAssociatedPart(part3);

            Product product2 = new Product
            {
                ProductID = Inventory.GenerateProductID(),
                Name = "MD369F ~500~",
                Price = 2700000.00m,
                Inventory = 5,
                Min = 1,
                Max = 10
            };

            product2.addAssociatedPart(part4);

            Inventory.addProduct(product1);
            Inventory.addProduct(product2);

            
            dg_parts.ClearSelection();
            dg_products.ClearSelection(); // this doesnt work and i dont know why

        }


        //Exits the main_form
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Add_Part form function. Simple and to the point, creates an instance of the form and passes 
        //ref of the inventory.
        private void btn_parts_add_Click(object sender, EventArgs e)
        {
            Add_Part addForm = new Add_Part(this.Inventory);

            addForm.ShowDialog(); //forces interaction with add_part form until complete
                                  //main_form code pauses and waits for part to be added
                                  //or the cancel button is pushed then the code below will fire
            dg_parts.ClearSelection();
            dg_parts.Refresh();

        }


        //Modify_Part form function. First check to see if a part is selected from the datagridview
        //create an instance of the form and passes selected part from datagrid view to the form along with
        //the inventory reference. Lastly use showdialog to ensure the clear selection and refresh work properly.
        private void btn_parts_modify_Click(object sender, EventArgs e)
        {

            if (dg_parts.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_parts.SelectedRows[0].Index;
                Part selectedPart = dg_parts.Rows[selectedIndex].DataBoundItem as Part;

                Modify_Part modifyPart = new Modify_Part(selectedPart, this.Inventory); //pass selected part to the modify_form
                

                modifyPart.ShowDialog();

                dg_parts.ClearSelection();
                dg_parts.Refresh();

            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }


        }
        //Delete Part function, checks for part selection within datagrid and asks for a confirmation
        //Also gives notification that the part has been deleted or if there was an error
        private void btn_parts_delete_Click(object sender, EventArgs e)
        {
            if (dg_parts.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_parts.SelectedRows[0].Index; //index of the datagrid
                Part selectedPart = dg_parts.Rows[selectedIndex].DataBoundItem as Part;
                //finds DataBoundItem at selectedIndex and casts into Part


                if (selectedPart != null)
                {

                    DialogResult result = MessageBox.Show("Confirm Delete", "Are you sure?!?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
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
            }

            else
            {
                MessageBox.Show("Please select a part to delete.");
            }


        }


        // Search function finds fist part.Name that contains what ever you 
        // type into the searchbox and changes the background color of the data
        //grid to match... now if it could only select that row... maybe later.
        private void btn_parts_search_Click(object sender, EventArgs e)
        {

            string find = tb_parts_search.Text.ToLower();
            bool partFound = false;


            //If search box is empty make all fields white and clear selection
            if (string.IsNullOrWhiteSpace(find))
            {
                foreach (DataGridViewRow row in dg_parts.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                }
                dg_parts.ClearSelection();
            }

            else  //Search using name field
            {
                foreach (DataGridViewRow row in dg_parts.Rows)
                {
                    Part part = row.DataBoundItem as Part;

                    if (part != null && part.Name.ToLower().Contains(find))
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                        row.Selected = true;
                        partFound = true; //flag for part not found messegebox

                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                    }

                }

                dg_parts.ClearSelection();
                if (!partFound)
                {
                    MessageBox.Show("Part not found!", "Search Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }

        private void btn_products_add_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product(this.Inventory);
            add_Product.ShowDialog(); 
            
            dg_products.ClearSelection(); //refresh datagrid and clear selection
            dg_products.Refresh();
        }

        private void btn_products_modify_Click(object sender, EventArgs e)
        {
            if (dg_products.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_products.SelectedRows[0].Index;
                Product selectedProduct = dg_products.Rows[selectedIndex].DataBoundItem as Product;

                Modify_Product modifyProduct = new Modify_Product(selectedProduct, this.Inventory) //pass selected part to the modify_form
                {
                    Inventory = this.Inventory
                };

                modifyProduct.ShowDialog();

                dg_parts.ClearSelection();
                dg_parts.Refresh();

            }
            else
            {
                MessageBox.Show("Please select a product to modify");
            }
        }

        private void btn_products_search_Click(object sender, EventArgs e)
        {
            {
                string find = tb_products_search.Text.ToLower();
                bool productFound= false;

                if (string.IsNullOrWhiteSpace(find)) {
                    foreach (DataGridViewRow row in dg_products.Rows)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }

                }
                else
                {
                    foreach (DataGridViewRow row in dg_products.Rows)
                    {
                        Product product = row.DataBoundItem as Product;
                        if (product != null && product.Name.ToLower().Contains(find))
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                            productFound = true;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                            
                        }
                        
                    }
                    dg_products.ClearSelection();
                    if (!productFound)
                    {
                        MessageBox.Show("Product not found!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btn_products_delete_Click(object sender, EventArgs e)
        {
            if (dg_products.SelectedRows.Count > 0) //are there products in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_products.SelectedRows[0].Index;
                Product selectedProduct = dg_products.Rows[selectedIndex].DataBoundItem as Product;


                if (selectedProduct != null)
                {

                    DialogResult result = MessageBox.Show("Confirm Delete", "Wait", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        int id = selectedProduct.ProductID;
                        if (Inventory.removeProduct(id))// Call your DeletePart function and check if it returns true
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the part.");
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }
    }
}
