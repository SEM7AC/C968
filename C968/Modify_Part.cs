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
        
        public Inventory Inventory { get; set; }
        public Modify_Part(Part part)
        {
            InitializeComponent();
            // Load the part data into the form controls
            tb_part_modify_id.Text = part.PartID.ToString();
            tb_part_modify_name.Text = part.Name;
            tb_part_modify_inventory.Text = part.InStock.ToString();
            tb_part_modify_priceCost.Text = part.Price.ToString();
            tb_part_modify_max.Text = part.Max.ToString();
            tb_part_modify_min.Text = part.Min.ToString();

            if (part is Inhouse inHousePart)
            {
                rb_part_modify_inHouse.Checked = true;
                lbl_part_modify_mi_cn.Text = "Machine ID";
                tb_part_modify_mi_cn.Text = inHousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                rb_part_modify_outsourced.Checked = true;
                lbl_part_modify_mi_cn.Text = "Company Name";
                tb_part_modify_mi_cn.Text = outsourcedPart.CompanyName;
            }
        }



        private void rb_part_modify_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Machine ID";
        }

        private void rb_part_modify_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Company Name";
        }

        private void btn_part_modify_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_part_modify_save_Click(object sender, EventArgs e)
        {
            /* Fix this later */

            this.Close();
        }
    }
}
