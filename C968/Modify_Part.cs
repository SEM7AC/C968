using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class Modify_Part : Form
    {
        private Part _modifyPart;
        public Inventory Inventory { get; set; }
        public Modify_Part(Part part)
        {
            InitializeComponent();

            _modifyPart = part; //saves the reference to the part obj that is passed into the form
                                //this is needed when save/updating an existing part instead of creating 
                                //a new part obj.

            // Load the part data into the form controls
            tb_part_modify_id.Text = part.PartID.ToString();
            tb_part_modify_name.Text = part.Name;
            tb_part_modify_inventory.Text = part.Inventory.ToString();
            tb_part_modify_priceCost.Text = part.Price.ToString();
            tb_part_modify_max.Text = part.Max.ToString();
            tb_part_modify_min.Text = part.Min.ToString();

            if (part is Inhouse inHousePart) //changes the label text based on type of part inhouse / outsourced
            {
                rb_part_modify_inHouse.Checked = true;
                lbl_part_modify_mi_cn.Text = "Machine ID";
                tb_part_modify_mi_cn.Text = inHousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart) //the is keyward is super useful
            {
                rb_part_modify_outsourced.Checked = true;
                lbl_part_modify_mi_cn.Text = "Company Name";
                tb_part_modify_mi_cn.Text = outsourcedPart.CompanyName;
            }
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
            isFormValid &= !string.IsNullOrWhiteSpace(tb_part_modify_name.Text);
            isFormValid &= int.TryParse(tb_part_modify_inventory.Text, out validInventory);
            isFormValid &= decimal.TryParse(tb_part_modify_priceCost.Text, out _);
            isFormValid &= int.TryParse(tb_part_modify_max.Text, out validMax);
            isFormValid &= int.TryParse(tb_part_modify_min.Text, out validMin);

            if (rb_part_modify_inHouse.Checked)
            {
                isFormValid &= int.TryParse(tb_part_modify_mi_cn.Text, out _);
            }
            else if (rb_part_modify_outsourced.Checked)
            {
                isFormValid &= !string.IsNullOrWhiteSpace(tb_part_modify_mi_cn.Text);
            }

            // Additional validation requirements: max > inventory > min
            // All three field must be entered before this check otherwise it gets annoying....
            // Additional validation requirements: max > inventory > min

            //Should consider using temp variables to reset min/max/values instead of clearing them
            //But this is also solved without saving the form and hitting cancel....
            if (!string.IsNullOrWhiteSpace(tb_part_modify_inventory.Text) &&
                !string.IsNullOrWhiteSpace(tb_part_modify_max.Text) &&
                !string.IsNullOrWhiteSpace(tb_part_modify_min.Text) &&
                int.TryParse(tb_part_modify_inventory.Text, out validInventory) &&
                int.TryParse(tb_part_modify_max.Text, out validMax) &&
                int.TryParse(tb_part_modify_min.Text, out validMin))
            {
                if (validMax < validInventory || validInventory < validMin)
                {
                    isFormValid = false;
                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_modify_inventory.Clear();
                    tb_part_modify_max.Clear();
                    tb_part_modify_min.Clear();
                }

                if (validMin > validMax)
                {
                    isFormValid = false;
                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_modify_inventory.Clear();
                    tb_part_modify_max.Clear();
                    tb_part_modify_min.Clear();
                }
            }
            //check requirements for anyonther validation and add them above this comment.....

            // Enable or disable the save button
            btn_part_modify_save.Enabled = isFormValid;

            if (btn_part_modify_save.Enabled)
            {
                btn_part_modify_save.BackColor = Color.Green;
                btn_part_modify_save.ForeColor = Color.White;
                btn_part_modify_save.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btn_part_modify_save.BackColor = Color.Gray;
                btn_part_modify_save.ForeColor = Color.DarkGray;
                btn_part_modify_save.FlatStyle = FlatStyle.Flat;
                btn_part_modify_save.FlatAppearance.BorderColor = Color.DarkGray;
            }

        }

        //Change Label depending on radio button selection
        private void rb_part_modify_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Machine ID";
        }

        private void rb_part_modify_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Company Name";
        }

        //Cancel the modify and discard the changes
        private void btn_part_modify_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_part_modify_save_Click(object sender, EventArgs e)
        {
            // Retrieve updated data from textboxes
            _modifyPart.Name = tb_part_modify_name.Text;
            _modifyPart.Inventory = int.Parse(tb_part_modify_inventory.Text);
            _modifyPart.Price = decimal.Parse(tb_part_modify_priceCost.Text);
            _modifyPart.Max = int.Parse(tb_part_modify_max.Text);
            _modifyPart.Min = int.Parse(tb_part_modify_min.Text);

            if (_modifyPart is Inhouse inhousePart)
            {
                inhousePart.MachineID = int.Parse(tb_part_modify_mi_cn.Text);
            }
            else if (_modifyPart is Outsourced outsourcedPart)
            {
                outsourcedPart.CompanyName = tb_part_modify_mi_cn.Text;
            }

            // Update the inventory and refresh the DataGridView in the main form
            Inventory.updatePart(_modifyPart.PartID, _modifyPart);

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
        private void tb_part_modify_name_TextChanged(object sender, EventArgs e)
        {

            // Validate Name textbox: Name must not be null or blank
            if (string.IsNullOrWhiteSpace(tb_part_modify_name.Text))
            {
                ValidateHelper(tb_part_modify_name, false); //false keeps the color red-ish
            }
            else
            {
                ValidateHelper(tb_part_modify_name, true); //true will turn it white
            }
            CheckFormValidity();
        }

        private void tb_part_modify_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            if (!int.TryParse(tb_part_modify_inventory.Text, out int inventory))
            {
                ValidateHelper(tb_part_modify_inventory, false);

            }
            else
            {
                ValidateHelper(tb_part_modify_inventory, true);
            }
            CheckFormValidity();
        }

        private void tb_part_modify_priceCost_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            if (!decimal.TryParse(tb_part_modify_priceCost.Text, out decimal price))
            {
                ValidateHelper(tb_part_modify_priceCost, false);

            }
            else
            {
                ValidateHelper(tb_part_modify_priceCost, true);
            }
            CheckFormValidity();
        }

        private void tb_part_modify_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            if (!int.TryParse(tb_part_modify_max.Text, out int max))
            {
                ValidateHelper(tb_part_modify_max, false);

            }
            else
            {
                ValidateHelper(tb_part_modify_max, true);
            }
            CheckFormValidity();
        }

        private void tb_part_modify_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            if (!int.TryParse(tb_part_modify_min.Text, out int min))
            {
                ValidateHelper(tb_part_modify_min, false);

            }
            else
            {
                ValidateHelper(tb_part_modify_min, true);
            }
            CheckFormValidity();
        }

        private void tb_part_modify_mi_cn_TextChanged(object sender, EventArgs e)
        {
            // Validate MachineID / Company Name depending on radio button selection either int or string
            // Its fixed finnaly
            if (rb_part_modify_inHouse.Checked && !int.TryParse(tb_part_modify_mi_cn.Text, out int machineID))
            {
                ValidateHelper(tb_part_modify_mi_cn, false);

            }
            else if (rb_part_modify_inHouse.Checked)
            {
                ValidateHelper(tb_part_modify_mi_cn, true);
            }
            // Must be string and not null or blank
            if (rb_part_modify_outsourced.Checked && string.IsNullOrWhiteSpace(tb_part_modify_mi_cn.Text))
            {
                ValidateHelper(tb_part_modify_mi_cn, false);

            }
            else if (rb_part_modify_outsourced.Checked)
            {
                ValidateHelper(tb_part_modify_mi_cn, true);
            }
            CheckFormValidity();
        }
    }
}
