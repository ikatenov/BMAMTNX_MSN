using TenTec.Windows.iGridLib;

namespace BMAMTNX
{
    public partial class FormFPY : Form
    {
        private int numberMeters;

        private bool[] arr;

        private const int COLUMN_WIDTH = 150;

        public event EventHandler<DataEnteredEventArgs>? DataEntered;

        private int numberGoodSerialNumbers = 0;


        public class DataEnteredEventArgs : EventArgs
        {
            public string[] Data { get; }

            public DataEnteredEventArgs(string[] data)
            {
                Data = data;
            }
        }

        public FormFPY()
        {
            InitializeComponent();
        }
       
        public void Show(string title, int numMeters, bool[] enabledPositions)
        {
            this.Text = title;

            numberMeters = numMeters;

            arr = new bool[numberMeters];
        
            Array.Copy(enabledPositions, 0, arr, 0, arr.Length);

            InitializeGrid();

            this.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           // if enter found

           // AMT-01 

           // check if first 4 characters are AMT-

           // if yes,  get integer and set focus to that serialNumber row if still still is needing serial number
           // clear edit box to ""

           
        }

        // need a capture function for when enter found scanning in serialNumber grid
        // so can put focus back to edit box if more to scan or close form and set event
        // and fill in 

        private void InitializeGrid()
        {
         
            iGrid1.BeginUpdate();

            int colWidth = COLUMN_WIDTH;
            if (this.DeviceDpi > 96)
                colWidth = colWidth * this.DeviceDpi / 96;
            iGrid1.DefaultCol.Width = colWidth;
            iGrid1.DefaultCol.AllowSizing = false;
            iGrid1.DefaultCol.SortType = iGSortType.None;

            iGrid1.Header.Font = new Font(iGrid1.Font.FontFamily, 10, FontStyle.Bold);
            iGrid1.Header.BackColor = Color.FromArgb(240, 240, 240);
            iGrid1.DefaultCol.ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;

            iGrid1.HScrollBar.Visibility = iGScrollBarVisibility.Hide;

            iGCol col;
            col = iGrid1.Cols.Add("position", "POSITION");
            col.CellStyle.ValueType = typeof(int);
            col.CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            

            col = iGrid1.Cols.Add("serialNumber", "SERIAL NUMBER");
            col.CellStyle.ValueType = typeof(string);
            col.CellStyle.TextAlign = iGContentAlignment.MiddleRight;
          
            col = iGrid1.Cols.Add("status", "STATUS");
            col.CellStyle.ValueType = typeof(string);
            col.CellStyle.TextAlign = iGContentAlignment.MiddleRight;

            int row = 0;

            foreach(bool b in arr)
            {
                // set position value

                if (b)
                {
                   
                    // set row color red
                    // set status value to "Missing SN"
                }
                else
                {
                    // set row color gray
                    // set status value to "EMPTY"
                }
                row++;
            }

            iGrid1.Rows.Count = numberMeters;


            iGrid1.EndUpdate();

        }

    }
}
