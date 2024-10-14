using TenTec.Windows.iGridLib;
using System.Linq;
using System.Collections;
using System;
using System.Reflection;
using System.Windows.Forms.Design.Behavior;

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
            if (e.KeyCode == Keys.Enter)
            {
                if( textBoxPosition.Text.StartsWith("AMT-") )
                {
                    // TODO   parse out the integer, which is the row position 
                    // but subract one
                    // example is AMT-1
                    // so row 0  Serial Number column needs focus so serial number can get scanned in and stored.

                    textBoxPosition.Enabled = false;
                }
                else // not a valid position label was scanned so start over
                {
                    textBoxPosition.Text = string.Empty;
                }

            }

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
            col.CellStyle.Selectable = iGBool.False;

            col.CellStyle.TextAlign = iGContentAlignment.MiddleLeft;


            col = iGrid1.Cols.Add("serialNumber", "SERIAL NUMBER");
            col.CellStyle.ValueType = typeof(string);
            col.CellStyle.Selectable = iGBool.False;
            col.CellStyle.TextAlign = iGContentAlignment.MiddleRight;

            col = iGrid1.Cols.Add("status", "STATUS");
            col.CellStyle.ValueType = typeof(string);
            col.CellStyle.Selectable = iGBool.False;
            col.CellStyle.TextAlign = iGContentAlignment.MiddleCenter;

            iGrid1.Rows.Count = numberMeters;

            // set up grid to match Amt meter front screen 
            foreach (var (item, index) in arr.WithIndex())
            {
                iGrid1.CellValues[index, "position"] = index + 1;

                if (item)
                {   
                    iGrid1.CellValues[index, "status"] = "MISSING SN";
                }
                else
                {                  
                    iGrid1.CellValues[index, "status"] = "EMPTY";

                }
            }

            iGrid1.EndUpdate();

        }

        private void iGrid1_CellDynamicContents(object sender,
iGCellDynamicContentsEventArgs e)
        {

            if( e.Text == "MISSING SN" )
            {
                iGrid1.Rows[e.RowIndex].CellStyle.BackColor = Color.Red;
            }
            else if (e.Text == "EMPTY")
            {
                iGrid1.Rows[e.RowIndex].CellStyle.BackColor = Color.Gray;
            }

            //int value = (int)iGrid1.CellValues[e.RowIndex, e.ColIndex];
            //switch (value)
            //{
            //    case 1:
            //        e.Text = "One";
            //        break;
            //    case 2:
            //        e.Text = "Two";
            //        break;
            //    case 3:
            //        e.Text = "Three";
            //        break;
            //}
        }


        private void FormFPY_Load(object sender, EventArgs e)
        {
            iGrid1.CellDynamicContents += iGrid1_CellDynamicContents;

            textBoxPosition.Focus();
        }
    }

    public static class extention
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }
    }
}

  
