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
    public partial class Modify_Product : Form
    {
        public Modify_Product()
        {
            InitializeComponent();
        }

        private void btn_modify_product_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
