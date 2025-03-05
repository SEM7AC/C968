using System.ComponentModel;

namespace C968
{
    public partial class Modify_Product : Form
    {
        private bool isNameValid = false; //Flags for validation
        private bool isInvValid = false;
        private bool isPriceValid = false;
        private bool isMaxValid = false;
        private bool isMinValid = false;
        public Inventory Inventory { get; set; }
        private Product _product;
        private BindingList<Part> _tempPartsList;


        public Modify_Product(Product product, Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            _product = product;
            //instance and assigns current ap list to a temp so we can restore if
            //necessary with the cancel button 
            _tempPartsList = new BindingList<Part>(_product.AssociatedParts.ToList());



            dg_modify_product_ap.DataSource = _product.AssociatedParts;
            dg_modify_product_cp.DataSource = Inventory.AllParts;

            // Load the part data into the form controls
            tb_product_modify_ID.Text = product.ProductID.ToString();
            tb_product_modify_name.Text = product.Name;
            tb_product_modify_inventory.Text = product.Inventory.ToString();
            tb_product_modify_price.Text = product.Price.ToString();
            tb_product_modify_max.Text = product.Max.ToString();
            tb_product_modify_min.Text = product.Min.ToString();




        }

        //Method to cancel and close form
        private void btn_product_modify_cancel_Click(object sender, EventArgs e)
        {
            //The textbox data wont change until the save button is pressed, but the associated parts will
            //this restores the old list when the cancel button is pressed before closing the form
            // Restore the associated parts from the temporary BindingList
            _product.AssociatedParts = new BindingList<Part>(_tempPartsList.ToList());

            // Close the form
            this.Close();

        }

        //Method for saving modified product info
        private void btn_product_modify_save_Click(object sender, EventArgs e)
        {

            CheckFormValidity();
            if (!btn_product_modify_save.Enabled)
            {
                // Abort if the form is invalid
                return;
            }

            // Retrieve updated data from textboxes
            _product.Name = tb_product_modify_name.Text;
            _product.Inventory = int.Parse(tb_product_modify_inventory.Text);
            _product.Price = decimal.Parse(tb_product_modify_price.Text);
            _product.Max = int.Parse(tb_product_modify_max.Text);
            _product.Min = int.Parse(tb_product_modify_min.Text);

            // Update the product passing the ID and _product with updated info
            Inventory.updateProduct(_product.ProductID, _product);

            this.Close();
        }

        //Method to add an associated part to product
        private void btn_product_modify_add_Click(object sender, EventArgs e)
        {
            if (dg_modify_product_cp.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_modify_product_cp.SelectedRows[0].Index;
                Part selectedPart = dg_modify_product_cp.Rows[selectedIndex].DataBoundItem as Part;


                if (selectedPart != null)
                {
                    _product.addAssociatedPart(selectedPart);
                }
            }
            else
            {
                MessageBox.Show("No parts to associate");
            }
        }

        //Method for deleting and associated part
        private void btn_product_modify_delete_Click(object sender, EventArgs e)
        {
            if (dg_modify_product_ap.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_modify_product_ap.SelectedRows[0].Index;
                Part selectedPart = dg_modify_product_ap.Rows[selectedIndex].DataBoundItem as Part;


                if (selectedPart != null)
                {
                    _product.removeAssociatedPart(selectedPart.PartID);
                }
            }
            else
            {
                MessageBox.Show("No parts to remove/disassociate");
            }

        }

        //Method to search canidate parts list
        private void btn_product_modify_search_Click(object sender, EventArgs e)
        {
            string find = tb_product_modify_search.Text.ToLower();
            bool partFound = false;


            //If search box is empty make all fields white and clear selection
            if (string.IsNullOrWhiteSpace(find))
            {
                foreach (DataGridViewRow row in dg_modify_product_cp.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                }
                dg_modify_product_cp.ClearSelection();
            }

            else  //Search using name field
            {
                foreach (DataGridViewRow row in dg_modify_product_cp.Rows)
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

                dg_modify_product_cp.ClearSelection();
                if (!partFound)
                {
                    MessageBox.Show("Part not found!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        /*--- Same validation as the Add_Part form ---*/

        public void ValidateHelper(TextBox tb, bool isValid)
        {
            if (tb != null && isValid == true)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.Coral;
            }

        }

        public void CheckFormComplete()
        {
            bool isComplete = isNameValid && isInvValid && isPriceValid &&
                              isMaxValid && isMinValid; //Global flags for validation



            // Enable or disable the save button based on the total form validation
            btn_product_modify_save.Enabled = isComplete;

            if (btn_product_modify_save.Enabled)
            {
                btn_product_modify_save.BackColor = Color.Green;
                btn_product_modify_save.ForeColor = Color.White;
                btn_product_modify_save.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btn_product_modify_save.BackColor = Color.Gray;
                btn_product_modify_save.ForeColor = Color.DarkGray;
                btn_product_modify_save.FlatStyle = FlatStyle.Flat;
                btn_product_modify_save.FlatAppearance.BorderColor = Color.DarkGray;
            }
        }

        private void CheckFormValidity()
        {


            int validInventory, validMax, validMin;


            // Additional validation requirements: max > inventory > min
            // Gets values and stores in validInventory, validMax, validMin

            if (int.TryParse(tb_product_modify_inventory.Text, out validInventory) &&
                int.TryParse(tb_product_modify_max.Text, out validMax) &&
                int.TryParse(tb_product_modify_min.Text, out validMin))
            {

                if (validMin > validMax) //Check this first to avoid 2 messegeboxs popping up
                {

                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the textbox and make user enter valid data, this also causes form to be invalidated
                    tb_product_modify_max.Clear();
                    tb_product_modify_min.Clear();

                    //Exit before more checks are done
                    return;

                }


                if (validMax < validInventory || validInventory < validMin) //Check Max > Inv > Min
                {

                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_modify_inventory.Clear();
                    tb_product_modify_max.Clear();
                    tb_product_modify_min.Clear();


                }


            }

        }


        /*--- Same validation as the Add_Part form ---*/

        private void tb_product_modify_name_TextChanged(object sender, EventArgs e)
        {
            isNameValid = !string.IsNullOrWhiteSpace(tb_product_modify_name.Text);

            ValidateHelper(tb_product_modify_name, isNameValid); //false keeps the color red-ish white for true

            CheckFormComplete();

        }

        private void tb_product_modify_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            isInvValid = int.TryParse(tb_product_modify_inventory.Text, out _);

            ValidateHelper(tb_product_modify_inventory, isInvValid);

            CheckFormComplete();

        }

        private void tb_product_modify_price_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            isPriceValid = decimal.TryParse(tb_product_modify_price.Text, out _);

            ValidateHelper(tb_product_modify_price, isPriceValid);

            CheckFormComplete();

        }

        private void tb_product_modify_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            isMaxValid = int.TryParse(tb_product_modify_max.Text, out _);

            ValidateHelper(tb_product_modify_max, isMaxValid);

            CheckFormComplete();

        }

        private void tb_product_modify_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            isMinValid = int.TryParse(tb_product_modify_min.Text, out _);

            ValidateHelper(tb_product_modify_min, isMinValid);

            CheckFormComplete();

        }

    }
}
