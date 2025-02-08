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
        public Modify_Part()
        {
            InitializeComponent();
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
