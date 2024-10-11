namespace BMAMTNX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowDialog_Click(object sender, EventArgs e)
        {
            FormManualSerialNumbers myForm = new FormManualSerialNumbers();
            myForm.Show("Sample title", 12);
        }
    }
}
