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
    public partial class Add_Part : Form
    {
        public Inventory Inventory { get; set; }
        public Add_Part()
        {
            InitializeComponent();
            tb_part_add_id.Text = Inventory.GeneratePartID().ToString();
        }

        private void radioButton_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Machine ID";
        }

        private void radioButton_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Company Name";
        }

        private void btn_part_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_part_save_Click(object sender, EventArgs e)
        {

            /*Add the code to save and manipultate textbox data */
            // Add data validation here before

            try
            {
                // Collect input data
                int partID = int.Parse(tb_part_add_id.Text);
                string name = tb_part_add_name.Text;
                decimal price = decimal.Parse(tb_part_add_priceCost.Text);
                int inventory = int.Parse(tb_part_add_inventory.Text);
                int min = int.Parse(tb_part_add_min.Text);
                int max = int.Parse(tb_part_add_max.Text);
                if (rb_part_add_inHouse.Checked)
                {
                    int machineID = int.Parse(tb_part_add_mi_cn.Text); // Parse int for MachineID
                    Inhouse newPart = new Inhouse(partID, name, price, inventory, min, max, machineID);
                    Inventory.addPart(newPart);
                }
                else if (rb_part_add_outsourced.Checked) 
                {
                    string cn = tb_part_add_mi_cn.Text;
                    Outsourced newPart = new Outsourced(partID, name, price, inventory, min, max, cn);
                    Inventory.addPart(newPart);
                }
                             

                
                

                // Close the form after adding the part
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding part: " + ex.Message);
            }



            this.Close();
        }
    }
}
