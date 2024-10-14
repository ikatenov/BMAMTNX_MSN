using static BMAMTNX.FormFPY;

namespace BMAMTNX
{
    public partial class FormMain : Form
    {
        FormFPY? MetersFpyForm;

        string[] MeterSerialNumbers;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonTest1_Click(object sender, EventArgs e)
        {
            int NumMeters = 12;

            bool[] arr = new bool[NumMeters];

            MetersFpyForm = new FormFPY();

            MetersFpyForm.DataEntered += FormFPY_DataEntered;

            MetersFpyForm.Show("SCAN METER POSITION =>  SCAN METER BARCODE", NumMeters, arr);


        }

        private void FormFPY_DataEntered(object? sender, DataEnteredEventArgs e)
        {
            MeterSerialNumbers = e.Data;
            MessageBox.Show($"Count = {e.Data.Length}", "FormFPY_DataEntered");
        }

    }
}
