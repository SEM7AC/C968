using System.ComponentModel;

namespace C968
{

    public partial class Add_Product : Form
    {
        private int productID; //Unique ID for products

        private BindingList<Part> temp_ap; //list for associated parts

        private bool isNameValid = false; //Flags for validation
        private bool isInvValid = false;
        private bool isPriceValid = false;
        private bool isMaxValid = false;
        private bool isMinValid = false;

        public Inventory Inventory { get; set; }
        public Add_Product(Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            temp_ap = new BindingList<Part>();
            dg_product_add_cp.DataSource = Inventory.AllParts;
            dg_product_add_ap.DataSource = temp_ap; //add associated parts to datagrid

            productID = Inventory.GenerateProductID();
            tb_product_add_ID.Text = productID.ToString();

        }

        private void btn_add_product_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_product_add_save_Click(object sender, EventArgs e)
        {
            CheckFormValidity();
            if (!btn_product_add_save.Enabled)
            {
                // Abort if the form is invalid
                return;
            }

            // Retrieve data from textboxes
            int productID = int.Parse(tb_product_add_ID.Text);
            string productName = tb_product_add_name.Text;
            int inventory = int.Parse(tb_product_add_inventory.Text);
            decimal price = decimal.Parse(tb_product_add_price.Text);
            int max = int.Parse(tb_product_add_max.Text);
            int min = int.Parse(tb_product_add_min.Text);



            Product new_product = new Product();
            new_product.ProductID = productID;
            new_product.Name = productName;
            new_product.Inventory = inventory;
            new_product.Price = price;
            new_product.Max = max;
            new_product.Min = min;

            if (dg_product_add_ap.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dg_product_add_ap.Rows)
                {
                    Part part = row.DataBoundItem as Part;
                    new_product.addAssociatedPart(part);
                }
            }

            Inventory.Products.Add(new_product);


            this.Close();
        }

        private void btn_product_add_add_Click(object sender, EventArgs e)
        {
            if (dg_product_add_cp.SelectedRows.Count > 0) //are there parts in the datagrid and 1 is selected 
            {
                int selectedIndex = dg_product_add_cp.SelectedRows[0].Index;
                Part selectedPart = dg_product_add_cp.Rows[selectedIndex].DataBoundItem as Part;
                temp_ap.Add(selectedPart);


            }
        }

        private void btn_add_product_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Button Clicked");
        }

        private void btn_product_add_search_Click(object sender, EventArgs e)
        {
            string find = tb_product_add_search.Text.ToLower();
            bool partFound = false;


            //If search box is empty make all fields white and clear selection
            if (string.IsNullOrWhiteSpace(find))
            {
                foreach (DataGridViewRow row in dg_product_add_cp.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                }
                dg_product_add_cp.ClearSelection();
            }

            else  //Search using name field
            {
                foreach (DataGridViewRow row in dg_product_add_cp.Rows)
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

                dg_product_add_cp.ClearSelection();
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
            btn_product_add_save.Enabled = isComplete;

            if (btn_product_add_save.Enabled)
            {
                btn_product_add_save.BackColor = Color.Green;
                btn_product_add_save.ForeColor = Color.White;
                btn_product_add_save.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btn_product_add_save.BackColor = Color.Gray;
                btn_product_add_save.ForeColor = Color.DarkGray;
                btn_product_add_save.FlatStyle = FlatStyle.Flat;
                btn_product_add_save.FlatAppearance.BorderColor = Color.DarkGray;
            }
        }

        private void CheckFormValidity()
        {


            int validInventory, validMax, validMin;


            // Additional validation requirements: max > inventory > min
            // Gets values and stores in validInventory, validMax, validMin

            if (int.TryParse(tb_product_add_inventory.Text, out validInventory) &&
                int.TryParse(tb_product_add_max.Text, out validMax) &&
                int.TryParse(tb_product_add_min.Text, out validMin))
            {

                if (validMin > validMax) //Check this first to avoid 2 messegeboxs popping up
                {

                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the textbox and make user enter valid data, this also causes form to be invalidated
                    tb_product_add_max.Clear();
                    tb_product_add_min.Clear();

                    //Exit before more checks are done
                    return;

                }


                if (validMax < validInventory || validInventory < validMin) //Check Max > Inv > Min
                {

                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_add_inventory.Clear();
                    tb_product_add_max.Clear();
                    tb_product_add_min.Clear();


                }


            }

        }



        /*--- Same validation as the Add_Part form ---*/

        private void tb_product_add_name_TextChanged(object sender, EventArgs e)
        {
            isNameValid = !string.IsNullOrWhiteSpace(tb_product_add_name.Text);

            ValidateHelper(tb_product_add_name, isNameValid); //false keeps the color red-ish white for true

            CheckFormComplete();
        }

        private void tb_product_add_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            isInvValid = int.TryParse(tb_product_add_inventory.Text, out _);

            ValidateHelper(tb_product_add_inventory, isInvValid);

            CheckFormComplete();
        }

        private void tb_product_add_price_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            isPriceValid = decimal.TryParse(tb_product_add_price.Text, out _);

            ValidateHelper(tb_product_add_price, isPriceValid);

            CheckFormComplete();
        }

        private void tb_product_add_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            isMaxValid = int.TryParse(tb_product_add_max.Text, out _);

            ValidateHelper(tb_product_add_max, isMaxValid);

            CheckFormComplete();
        }

        private void tb_product_add_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            isMinValid = int.TryParse(tb_product_add_min.Text, out _);

            ValidateHelper(tb_product_add_min, isMinValid);

            CheckFormComplete();
        }


    }
}
