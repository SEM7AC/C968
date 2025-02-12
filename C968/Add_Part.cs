using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968
{
    public partial class Add_Part : Form
    {
        public bool saveOK = false;
        public Inventory Inventory { get; set; }
        public Add_Part()
        {
            InitializeComponent();
            tb_part_add_id.Text = Inventory.GeneratePartID().ToString();

        }

        //Helper for validation code.....

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

            int validInventory =0;
            int validMax = 0;
            int validMin = 0;
            // Check each TextBox's validation
            isFormValid &= !string.IsNullOrWhiteSpace(tb_part_add_name.Text);
            isFormValid &= int.TryParse(tb_part_add_inventory.Text, out validInventory);
            isFormValid &= decimal.TryParse(tb_part_add_priceCost.Text, out _);
            isFormValid &= int.TryParse(tb_part_add_max.Text, out validMax);
            isFormValid &= int.TryParse(tb_part_add_min.Text, out validMin);

            if (rb_part_add_inHouse.Checked)
            {
                isFormValid &= int.TryParse(tb_part_add_mi_cn.Text, out _);
            }
            else if (rb_part_add_outsourced.Checked)
            {
                isFormValid &= !string.IsNullOrWhiteSpace(tb_part_add_mi_cn.Text);
            }

            // Additional validation requirements: max > inventory > min
            // All three field must be entered before this check otherwise it gets annoying....
            // Additional validation requirements: max > inventory > min
            if (!string.IsNullOrWhiteSpace(tb_part_add_inventory.Text) &&
                !string.IsNullOrWhiteSpace(tb_part_add_max.Text) &&
                !string.IsNullOrWhiteSpace(tb_part_add_min.Text) &&
                int.TryParse(tb_part_add_inventory.Text, out validInventory) &&
                int.TryParse(tb_part_add_max.Text, out validMax) &&
                int.TryParse(tb_part_add_min.Text, out validMin))
            {
                if (validMax < validInventory || validInventory < validMin)
                {
                    isFormValid = false;
                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_add_inventory.Clear();
                    tb_part_add_max.Clear();
                    tb_part_add_min.Clear();
                }

                if (validMin > validMax)
                {
                    isFormValid = false;
                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_add_inventory.Clear();
                    tb_part_add_max.Clear();
                    tb_part_add_min.Clear();
                }
            }
            //check requirements for anyonther validation and add them above this comment.....

            // Enable or disable the save button
            btn_part_add_save.Enabled = isFormValid;

            if (btn_part_add_save.Enabled)
            {
                btn_part_add_save.BackColor = Color.Green;
                btn_part_add_save.ForeColor = Color.White;
                btn_part_add_save.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btn_part_add_save.BackColor = Color.Gray;
                btn_part_add_save.ForeColor = Color.DarkGray;
                btn_part_add_save.FlatStyle = FlatStyle.Flat;
                btn_part_add_save.FlatAppearance.BorderColor = Color.DarkGray;
            }

        }

        private void radioButton_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Machine ID";
            CheckFormValidity();
        }

        private void radioButton_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Company Name";
            CheckFormValidity();
        }

        private void btn_part_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_part_save_Click(object sender, EventArgs e)
        {

            // Retrieve data from textboxes
            int partID = int.Parse(tb_part_add_id.Text);
            string partName = tb_part_add_name.Text;
            int inventory = int.Parse(tb_part_add_inventory.Text);
            decimal price = decimal.Parse(tb_part_add_priceCost.Text);
            int max = int.Parse(tb_part_add_max.Text);
            int min = int.Parse(tb_part_add_min.Text);
            string mi_cn = tb_part_add_mi_cn.Text;

            // Check if in-house or outsourced part
            

            // Perform the save operation
            if (rb_part_add_inHouse.Checked)
            {
                // Save in-house part with machine ID
                int machineID = int.Parse(mi_cn);
                Part part = new Inhouse(partID, partName, price, inventory,  min, max, machineID);
                Inventory.addPart(part);
            }
            else
            {
                // Save outsourced part with company name
                Part part = new Outsourced(partID, partName, price, inventory, min, max, mi_cn);
                Inventory.addPart(part);
                
            }

            // Close the form or provide feedback to the user
            this.Close();
            this.Close();
        }

        /********************************************************************************/
        // This section contains all TextChanged events and performs validation          /
        // Validation for each textbox happens as data is entered                        /
        // Helper Function to change color of textbox if validation passes               /
        // Full form validation is called after each event to validate form and perform  /
        // final validation requiring all fields to be filled in with valid data.        /
        /********************************************************************************/
        private void tb_part_add_name_TextChanged(object sender, EventArgs e)
        {

            // Validate Name textbox: Name must not be null or blank
            if (string.IsNullOrWhiteSpace(tb_part_add_name.Text))
            {
                ValidateHelper(tb_part_add_name, false); //false keeps the color red-ish
            }
            else
            {
                ValidateHelper(tb_part_add_name, true); //true will turn it white
            }
            CheckFormValidity();
        }

        private void tb_part_add_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            if (!int.TryParse(tb_part_add_inventory.Text, out int inventory))
            {
                ValidateHelper(tb_part_add_inventory, false);

            }
            else
            {
                ValidateHelper(tb_part_add_inventory, true);
            }
            CheckFormValidity();
        }

        private void tb_part_add_priceCost_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            if (!decimal.TryParse(tb_part_add_priceCost.Text, out decimal price))
            {
                ValidateHelper(tb_part_add_priceCost, false);

            }
            else
            {
                ValidateHelper(tb_part_add_priceCost, true);
            }
            CheckFormValidity();
        }

        private void tb_part_add_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            if (!int.TryParse(tb_part_add_max.Text, out int max))
            {
                ValidateHelper(tb_part_add_max, false);
                
            }
            else
            {
                ValidateHelper(tb_part_add_max, true);
            }
            CheckFormValidity();
        }

        private void tb_part_add_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            if (!int.TryParse(tb_part_add_min.Text, out int min))
            {
                ValidateHelper(tb_part_add_min, false);
                
            }
            else
            {
                ValidateHelper(tb_part_add_min, true);
            }
            CheckFormValidity();
        }

        private void tb_part_add_mi_cn_TextChanged(object sender, EventArgs e)
        {
            // Validate MachineID / Company Name depending on radio button selection either int or string
            // FIX THIS SECTION AHHHHHHHHHHH
            if (rb_part_add_inHouse.Checked && !int.TryParse(tb_part_add_mi_cn.Text, out int machineID))
            {
                ValidateHelper(tb_part_add_mi_cn, false);
                
            }
            else if (rb_part_add_inHouse.Checked)
            {
                ValidateHelper(tb_part_add_mi_cn, true);
            }
            // Must be string and not null or blank
            if (rb_part_add_outsourced.Checked && string.IsNullOrWhiteSpace(tb_part_add_mi_cn.Text))
            {
                ValidateHelper(tb_part_add_mi_cn, false);
                
            }
            else if (rb_part_add_outsourced.Checked)
            {
                ValidateHelper(tb_part_add_mi_cn, true);
            }
            CheckFormValidity();
        }
    }
}
