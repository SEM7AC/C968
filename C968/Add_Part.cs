namespace C968
{
    public partial class Add_Part : Form
    {
        private int partID; //stores unique partID
        
        private bool isNameValid = false; //Flags for validation
        private bool isInvValid = false;
        private bool isPriceValid = false;
        private bool isMaxValid = false;
        private bool isMinValid = false;
        private bool isMICN_Valid = false;

        

        public Inventory Inventory { get; set; } //includes inventory
        public Add_Part(Inventory inventory) //Add_Part constructor
        {
            
            InitializeComponent();
            Inventory = inventory;
            partID = Inventory.GeneratePartID(); //gets unique partID
            tb_part_add_id.Text = partID.ToString(); //sets readonly text box on form 
        }

        private void radioButton_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Machine ID";
            /*Forced check when text doesnt change and radio buttons are toggled, found this bug while 
             * testing. When radio buttons are toggled with data in the box it will bypass 
             * tb_part_add_mi_cn_TextChanged method which is the start of the validation series and cause an 
             * error. It will attempt to parse a string into an int. Not good!*/
            tb_part_add_mi_cn_TextChanged(sender, e);
            CheckFormValidity();
        }

        private void radioButton_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_part_add_mi_cn.Text = "Company Name";
            CheckFormValidity();
        }

        private void btn_part_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes form: Best cancel ever!
        }

        private void btn_part_save_Click(object sender, EventArgs e)
        {
            /*
            Cross-Field validation Max > Inventory > Min and Max > Min 
            Added this method because of testing requirements of clicking
            the save button before these last validations were checked.
            So much time spent here.
            */
            CheckFormValidity(); 
            if (!btn_part_add_save.Enabled)
            {
                // Abort if the form is invalid
                return;
            }

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
                Part NewInhousePart = new Inhouse(partID, partName, price, inventory, min, max, machineID);

                Inventory.addPart(NewInhousePart);

            }
            else
            {
                // Save outsourced part with company name
                Part NewOutsourcedPart = new Outsourced(partID, partName, price, inventory, min, max, mi_cn);
                Inventory.addPart(NewOutsourcedPart);


            }

            this.Close(); //Close form

        }
        
        
        
        /*
        Changes the colors of the textbox if the data is valid/invalid
        */
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

        /*
        This checks the entire form to make sure all textboxes have data entered and they
        should contain a valid data type that was checked in the textChanged methods. 
        This is to enable or disable the save button until the entire form is filled in.
         */
        public void CheckFormComplete()
        {
            bool isComplete = isNameValid && isInvValid && isPriceValid && 
                              isMaxValid && isMinValid && isMICN_Valid; //Global flags for validation
                                

            
            // Enable or disable the save button based on the total form validation
            btn_part_add_save.Enabled = isComplete;

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

        /*
        This is the final validation that happens after the save button is pressed
        This checks for Max > Inv > Min and that Max > Min. 
        This is called from inside the btn_part_save_Click method.
         */
        public void CheckFormValidity()
        {

            
            int validInventory, validMax, validMin;


            // Additional validation requirements: max > inventory > min
            // Gets values and stores in validInventory, validMax, validMin

            if (int.TryParse(tb_part_add_inventory.Text, out validInventory) &&
                int.TryParse(tb_part_add_max.Text, out validMax) &&
                int.TryParse(tb_part_add_min.Text, out validMin)) 
            {

                if (validMin > validMax) //Check this first to avoid 2 messegeboxs popping up
                {

                    MessageBox.Show("Min cannot be greater than Max", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the textbox and make user enter valid data, this also causes form to be invalidated
                    tb_part_add_max.Clear();
                    tb_part_add_min.Clear();
                    
                    //Exit before more checks are done
                    return;
                    
                }


                if (validMax < validInventory || validInventory < validMin) //Check Max > Inv > Min
                {
                    
                    MessageBox.Show("Inventory must be between Max and Min values", "Out of Range",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_part_add_inventory.Clear();
                    tb_part_add_max.Clear();
                    tb_part_add_min.Clear();
                    
                    
                }

                
            }



        }

        
        /*
        This section contains all TextChanged events and performs type validation upon input          
        The global flags are set and used in the Helper method.                        
        ValidateHelper is used to change color of textbox if validation passes               
        Form completeness will be checked at the end of each textbox validation                       
        */
        private void tb_part_add_name_TextChanged(object sender, EventArgs e)
        {
            isNameValid = !string.IsNullOrWhiteSpace(tb_part_add_name.Text);
            
            ValidateHelper(tb_part_add_name, isNameValid); //false keeps the color red-ish white for true
           
            CheckFormComplete();
        }

        private void tb_part_add_inventory_TextChanged(object sender, EventArgs e)
        {
            // Validate Inventory textbox: Must be an int
            isInvValid = int.TryParse(tb_part_add_inventory.Text, out _);
            
            ValidateHelper(tb_part_add_inventory, isInvValid);

            CheckFormComplete();
        }

        private void tb_part_add_priceCost_TextChanged(object sender, EventArgs e)
        {
            // Validate Price textbox: Must be a decimal
            isPriceValid = decimal.TryParse(tb_part_add_priceCost.Text, out _);

            ValidateHelper(tb_part_add_priceCost, isPriceValid);
            
            CheckFormComplete();
        }

        private void tb_part_add_max_TextChanged(object sender, EventArgs e)
        {
            // Validate Max textbox: Must be an int
            isMaxValid = int.TryParse(tb_part_add_max.Text, out _);
            
            ValidateHelper(tb_part_add_max, isMaxValid);

            CheckFormComplete();
        }

        private void tb_part_add_min_TextChanged(object sender, EventArgs e)
        {
            // Validate Min textbox: Must be an int
            isMinValid = int.TryParse(tb_part_add_min.Text, out _);
            
            ValidateHelper(tb_part_add_min, isMinValid);
            
            CheckFormComplete();
        }

        private void tb_part_add_mi_cn_TextChanged(object sender, EventArgs e)
        {
            // Validate MachineID / Company Name depending on radio button selection either int or string
            // Its fixed finnaly
            if (rb_part_add_inHouse.Checked)
            {
                isMICN_Valid = int.TryParse(tb_part_add_mi_cn.Text, out _);
                ValidateHelper(tb_part_add_mi_cn, isMICN_Valid);
                
            }
            else
            {
                isMICN_Valid = !string.IsNullOrWhiteSpace(tb_part_add_mi_cn.Text);
                ValidateHelper(tb_part_add_mi_cn, isMICN_Valid);
            }

            CheckFormComplete();
        }
    }
}
