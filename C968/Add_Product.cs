namespace C968
{

    public partial class Add_Product : Form
    {
        private int productID; //Unique ID for products

        public Inventory Inventory { get; set; }
        public Add_Product(Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            dg_product_add_cp.DataSource = Inventory.AllParts;

            productID = Inventory.GenerateProductID();
            tb_product_add_ID.Text = productID.ToString();

        }

        private void btn_add_product_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_product_add_save_Click(object sender, EventArgs e)
        {
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

            Inventory.Products.Add(new_product);


            this.Close();
        }
        private void btn_product_add_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Button Clicked");
        }
        private void btn_add_product_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Button Clicked");
        }
        private void btn_product_add_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Button Clicked");
        }



        //
        // Same validation for Add_Part form used here...
        //
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

        private void CheckFormValidity()
        {
            bool isFormValid = true;

            int validInventory = 0;
            int validMax = 0;
            int validMin = 0;
            // Check each TextBox's validation
            isFormValid &= !string.IsNullOrWhiteSpace(tb_product_add_name.Text);
            isFormValid &= int.TryParse(tb_product_add_inventory.Text, out validInventory);
            isFormValid &= decimal.TryParse(tb_product_add_price.Text, out _);
            isFormValid &= int.TryParse(tb_product_add_max.Text, out validMax);
            isFormValid &= int.TryParse(tb_product_add_min.Text, out validMin);


            // Additional validation requirements: max > inventory > min
            // All three field must be entered before this check otherwise it gets annoying....
            // Additional validation requirements: max > inventory > min
            if (!string.IsNullOrWhiteSpace(tb_product_add_inventory.Text) &&
                !string.IsNullOrWhiteSpace(tb_product_add_max.Text) &&
                !string.IsNullOrWhiteSpace(tb_product_add_min.Text) &&
                int.TryParse(tb_product_add_inventory.Text, out validInventory) &&
                int.TryParse(tb_product_add_max.Text, out validMax) &&
                int.TryParse(tb_product_add_min.Text, out validMin))
            {
                if (validMax < validInventory || validInventory < validMin)
                {
                    isFormValid = false;
                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_add_inventory.Clear();
                    tb_product_add_max.Clear();
                    tb_product_add_min.Clear();
                }

                if (validMin > validMax)
                {
                    isFormValid = false;
                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_add_inventory.Clear();
                    tb_product_add_max.Clear();
                    tb_product_add_min.Clear();
                }
            }

            // Enable or disable the save button
            btn_product_add_save.Enabled = isFormValid;

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



        /********************************************************************************/
        // This section contains all TextChanged events and performs validation          /
        // Validation for each textbox happens as data is entered                        /
        // Helper Function to change color of textbox if validation passes               /
        // Full form validation is called after each event to validate form and perform  /
        // final validation requiring all fields to be filled in with valid data.        /
        /********************************************************************************/
        private void tb_product_add_name_TextChanged(object sender, EventArgs e)
        {
            // Validate Name textbox: Name must not be null or blank
            if (string.IsNullOrWhiteSpace(tb_product_add_name.Text))
            {
                ValidateHelper(tb_product_add_name, false); //false keeps the color red-ish
            }
            else
            {
                ValidateHelper(tb_product_add_name, true); //true will turn it white
            }
            CheckFormValidity();
        }

        private void tb_product_add_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            if (!int.TryParse(tb_product_add_inventory.Text, out int inventory))
            {
                ValidateHelper(tb_product_add_inventory, false);

            }
            else
            {
                ValidateHelper(tb_product_add_inventory, true);
            }
            CheckFormValidity();
        }

        private void tb_product_add_price_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            if (!decimal.TryParse(tb_product_add_price.Text, out decimal price))
            {
                ValidateHelper(tb_product_add_price, false);

            }
            else
            {
                ValidateHelper(tb_product_add_price, true);
            }
            CheckFormValidity();
        }

        private void tb_product_add_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            if (!int.TryParse(tb_product_add_max.Text, out int max))
            {
                ValidateHelper(tb_product_add_max, false);

            }
            else
            {
                ValidateHelper(tb_product_add_max, true);
            }
            CheckFormValidity();
        }

        private void tb_product_add_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            if (!int.TryParse(tb_product_add_min.Text, out int min))
            {
                ValidateHelper(tb_product_add_min, false);

            }
            else
            {
                ValidateHelper(tb_product_add_min, true);
            }
            CheckFormValidity();
        }

        
    }
}
