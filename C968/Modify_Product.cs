﻿namespace C968
{
    public partial class Modify_Product : Form
    {
        public Inventory Inventory { get; set; }
        private Product _product;
        public Modify_Product(Product product, Inventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            _product = product;

            // Load the part data into the form controls
            tb_product_modify_ID.Text = product.ProductID.ToString();
            tb_product_modify_name.Text = product.Name;
            tb_product_modify_inventory.Text = product.Inventory.ToString();
            tb_product_modify_price.Text = product.Price.ToString();
            tb_product_modify_max.Text = product.Max.ToString();
            tb_product_modify_min.Text = product.Min.ToString();
        }

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
            isFormValid &= !string.IsNullOrWhiteSpace(tb_product_modify_name.Text);
            isFormValid &= int.TryParse(tb_product_modify_inventory.Text, out validInventory);
            isFormValid &= decimal.TryParse(tb_product_modify_price.Text, out _);
            isFormValid &= int.TryParse(tb_product_modify_max.Text, out validMax);
            isFormValid &= int.TryParse(tb_product_modify_min.Text, out validMin);



            // Additional validation requirements: max > inventory > min
            // All three field must be entered before this check otherwise it gets annoying....
            // Additional validation requirements: max > inventory > min

            //Should consider using temp variables to reset min/max/values instead of clearing them
            //But this is also solved without saving the form and hitting cancel....
            if (!string.IsNullOrWhiteSpace(tb_product_modify_inventory.Text) &&
                !string.IsNullOrWhiteSpace(tb_product_modify_max.Text) &&
                !string.IsNullOrWhiteSpace(tb_product_modify_min.Text) &&
                int.TryParse(tb_product_modify_inventory.Text, out validInventory) &&
                int.TryParse(tb_product_modify_max.Text, out validMax) &&
                int.TryParse(tb_product_modify_min.Text, out validMin))
            {
                if (validMax < validInventory || validInventory < validMin)
                {
                    isFormValid = false;
                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_modify_inventory.Clear();
                    tb_product_modify_max.Clear();
                    tb_product_modify_min.Clear();
                }

                if (validMin > validMax)
                {
                    isFormValid = false;
                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_product_modify_inventory.Clear();
                    tb_product_modify_max.Clear();
                    tb_product_modify_min.Clear();
                }
            }
            //check requirements for anyonther validation and add them above this comment.....

            // Enable or disable the save button
            btn_product_modify_save.Enabled = isFormValid;

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


        private void btn_modify_product_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_product_modify_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_product_modify_save_Click(object sender, EventArgs e)
        {
            // Retrieve updated data from textboxes
            _product.Name = tb_product_modify_name.Text;
            _product.Inventory = int.Parse(tb_product_modify_inventory.Text);
            _product.Price = decimal.Parse(tb_product_modify_price.Text);
            _product.Max = int.Parse(tb_product_modify_max.Text);
            _product.Min = int.Parse(tb_product_modify_min.Text);



            // Update the inventory and refresh the DataGridView in the main form
            Inventory.updateProduct(_product.ProductID, _product);

            this.Close();
        }

        private void tb_product_modify_name_TextChanged(object sender, EventArgs e)
        {
            // Validate Name textbox: Name must not be null or blank
            if (string.IsNullOrWhiteSpace(tb_product_modify_name.Text))
            {
                ValidateHelper(tb_product_modify_name, false); //false keeps the color red-ish
            }
            else
            {
                ValidateHelper(tb_product_modify_name, true); //true will turn it white
            }
            CheckFormValidity();

        }

        private void tb_product_modify_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            if (!int.TryParse(tb_product_modify_inventory.Text, out int inventory))
            {
                ValidateHelper(tb_product_modify_inventory, false);

            }
            else
            {
                ValidateHelper(tb_product_modify_inventory, true);
            }
            CheckFormValidity();

        }

        private void tb_product_modify_price_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            if (!decimal.TryParse(tb_product_modify_price.Text, out decimal price))
            {
                ValidateHelper(tb_product_modify_price, false);

            }
            else
            {
                ValidateHelper(tb_product_modify_price, true);
            }
            CheckFormValidity();

        }

        private void tb_product_modify_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            if (!int.TryParse(tb_product_modify_max.Text, out int max))
            {
                ValidateHelper(tb_product_modify_max, false);

            }
            else
            {
                ValidateHelper(tb_product_modify_max, true);
            }
            CheckFormValidity();

        }

        private void tb_product_modify_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            if (!int.TryParse(tb_product_modify_min.Text, out int min))
            {
                ValidateHelper(tb_product_modify_min, false);

            }
            else
            {
                ValidateHelper(tb_product_modify_min, true);
            }
            CheckFormValidity();

        }
    }
}
