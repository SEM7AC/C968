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
    public partial class Add_Product : Form
    {
        Inventory Inventory = new Inventory();
        public Add_Product(Inventory inventory)
        {
            InitializeComponent();
            dg_add_product_cp.DataSource = inventory.AllParts;
            
        }

        private void btn_add_product_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
