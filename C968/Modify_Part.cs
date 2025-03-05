using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace C968
{
    public partial class Modify_Part : Form
    {
       

        private Part _modifyPart;
        
        private bool isNameValid = false; //Flags for validation
        private bool isInvValid = false;
        private bool isPriceValid = false;
        private bool isMaxValid = false;
        private bool isMinValid = false;
        private bool isMICN_Valid = false;

        public Inventory Inventory { get; set; }
        public Modify_Part(Part part, Inventory inventory)
        {
            InitializeComponent();

            _modifyPart = part;     //saves the reference to the part obj that is passed into the form
            Inventory = inventory;  // Inventory passed from main form.
             

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
            else if (part is Outsourced outsourcedPart) //the is keyword is super useful
            {
                rb_part_modify_outsourced.Checked = true;
                lbl_part_modify_mi_cn.Text = "Company Name";
                tb_part_modify_mi_cn.Text = outsourcedPart.CompanyName;

            }
        }

       
        //Change Label depending on radio button selection
        private void rb_part_modify_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Machine ID";
            /*Forced check when text doesnt change and radio buttons are toggled, found this bug while 
             * testing. When radio buttons are toggled with data in the box it will bypass 
             * tb_part_add_mi_cn_TextChanged method which is the start of the validation series and cause an 
             * error. It will attempt to parse a string into an int. Not good!*/
            tb_part_modify_mi_cn_TextChanged(sender, e);
            CheckFormValidity();
        }

        private void rb_part_modify_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_modify_mi_cn.Text = "Company Name";
            CheckFormValidity();
        }
                
        private void btn_part_modify_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_part_modify_save_Click(object sender, EventArgs e)
        {
            CheckFormValidity();
            if (!btn_part_modify_save.Enabled)
            {
                // Abort if the form is invalid
                return;
            }

            // Retrieve updated data from textboxes
            _modifyPart.Name = tb_part_modify_name.Text;
            _modifyPart.Inventory = int.Parse(tb_part_modify_inventory.Text);
            _modifyPart.Price = decimal.Parse(tb_part_modify_priceCost.Text);
            _modifyPart.Max = int.Parse(tb_part_modify_max.Text);
            _modifyPart.Min = int.Parse(tb_part_modify_min.Text);
           

             if (rb_part_modify_inHouse.Checked ) //inhouse checked
             {
                if (_modifyPart is Inhouse ih_part) //part is inhouse type
                {
                    // Update existing Inhouse part
                    ih_part.MachineID = int.Parse(tb_part_modify_mi_cn.Text); //convert for inhouse 
                }
                else //if not Inhouse create a new part with old ID  
                {
                    int PartID = _modifyPart.PartID;
                    string Name = _modifyPart.Name;
                    decimal Price = _modifyPart.Price;
                    int Inventory = _modifyPart.Inventory;
                    int Min = _modifyPart.Min;
                    int Max = _modifyPart.Max;
                    int MachineID = int.Parse(tb_part_modify_mi_cn.Text);
                    // Create new Inhouse part
                    _modifyPart = new Inhouse(PartID,Name,Price,Inventory,Min,Max,MachineID);
                    
                        
                    
                }
            }
            else if (rb_part_modify_outsourced.Checked ) //if outsoucred is checked
            {
            
                if (_modifyPart is Outsourced os_part) //and it is an outsourced part
                {
                    // Update existing Outsourced part
                    os_part.CompanyName = tb_part_modify_mi_cn.Text;
                }
                else //create a new outsourced part with old ID
                {
                    int PartID = _modifyPart.PartID;
                    string Name = _modifyPart.Name;
                    int Inventory = _modifyPart.Inventory;
                    decimal Price = _modifyPart.Price;
                    int Max = _modifyPart.Max;
                    int Min = _modifyPart.Min;
                    string CompanyName = tb_part_modify_mi_cn.Text;
                    // Create new Outsourced part
                    _modifyPart = new Outsourced(PartID, Name, Price, Inventory, Min, Max, CompanyName);


                }
            }

            // Update the inventory and refresh the DataGridView in the main form
            Inventory.updatePart(_modifyPart.PartID, _modifyPart);

            this.Close();
        }

        /*--- Same validation as the Add_Part form ---*/

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

        public void CheckFormComplete()
        {
            bool isComplete = isNameValid && isInvValid && isPriceValid &&
                              isMaxValid && isMinValid && isMICN_Valid; //Global flags for validation



            // Enable or disable the save button based on the total form validation
            btn_part_modify_save.Enabled = isComplete;

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

        private void CheckFormValidity()
        {

            int validInventory, validMax, validMin;


            // Additional validation requirements: max > inventory > min
            // Gets values and stores in validInventory, validMax, validMin

            if (int.TryParse(tb_part_modify_inventory.Text, out validInventory) &&
                int.TryParse(tb_part_modify_max.Text, out validMax) &&
                int.TryParse(tb_part_modify_min.Text, out validMin))
            {

                if (validMin > validMax) //Check this first to avoid 2 messegeboxs popping up
                {

                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the textbox and make user enter valid data, this also causes form to be invalidated
                    tb_part_modify_max.Clear();
                    tb_part_modify_min.Clear();

                    //Exit before more checks are done
                    return;

                }


                if (validMax < validInventory || validInventory < validMin) //Check Max > Inv > Min
                {

                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_modify_inventory.Clear();
                    tb_part_modify_max.Clear();
                    tb_part_modify_min.Clear();


                }


            }
        }


        /*--- Same validation as the Add_Part form ---*/
        private void tb_part_modify_name_TextChanged(object sender, EventArgs e)
        {

            isNameValid = !string.IsNullOrWhiteSpace(tb_part_modify_name.Text);

            ValidateHelper(tb_part_modify_name, isNameValid); //false keeps the color red-ish white for true

            CheckFormComplete();
        }

        private void tb_part_modify_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            isInvValid = int.TryParse(tb_part_modify_inventory.Text, out _);

            ValidateHelper(tb_part_modify_inventory, isInvValid);

            CheckFormComplete();
        }

        private void tb_part_modify_priceCost_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            isPriceValid = decimal.TryParse(tb_part_modify_priceCost.Text, out _);

            ValidateHelper(tb_part_modify_priceCost, isPriceValid);

            CheckFormComplete();
        }

        private void tb_part_modify_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            isMaxValid = int.TryParse(tb_part_modify_max.Text, out _);

            ValidateHelper(tb_part_modify_max, isMaxValid);

            CheckFormComplete();
        }

        private void tb_part_modify_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            isMinValid = int.TryParse(tb_part_modify_min.Text, out _);

            ValidateHelper(tb_part_modify_min, isMinValid);

            CheckFormComplete();
        }

        private void tb_part_modify_mi_cn_TextChanged(object sender, EventArgs e)
        {
            // Validate MachineID / Company Name depending on radio button selection either int or string
            // Its fixed finnaly
            if (rb_part_modify_inHouse.Checked)
            {
                isMICN_Valid = int.TryParse(tb_part_modify_mi_cn.Text, out _);
                ValidateHelper(tb_part_modify_mi_cn, isMICN_Valid);

            }
            else
            {
                isMICN_Valid = !string.IsNullOrWhiteSpace(tb_part_modify_mi_cn.Text);
                ValidateHelper(tb_part_modify_mi_cn, isMICN_Valid);
            }

            CheckFormComplete();
        }
    }
}
