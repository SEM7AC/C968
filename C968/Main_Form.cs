namespace C968
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_parts_add_Click(object sender, EventArgs e)
        {
            Add_Part addForm = new();
            addForm.Show();
        }

        private void btn_parts_modify_Click(object sender, EventArgs e)
        {
            Modify_Part modifyPart = new();
            modifyPart.Show();
        }
    }
}
