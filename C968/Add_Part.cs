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
        public Add_Part()
        {
            InitializeComponent();
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

            this.Close();
        }
    }
}
