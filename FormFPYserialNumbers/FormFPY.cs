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

            textBoxPosition.Focus();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            const string cRowPrefix = "AMT-";

            if (e.KeyCode == Keys.Enter)
            {
                if( textBoxPosition.Text.StartsWith(cRowPrefix) )
                {
                    string position = textBoxPosition.Text.Substring(cRowPrefix.Length);
                    if (int.TryParse(position, out int rowIndex))
                    {
                        if (rowIndex >= 1 && rowIndex <= iGrid1.Rows.Count)
                        {
                            iGrid1.SetCurCell(rowIndex - 1, "serialNumber");
                        }
                    }

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
            //col.CellStyle.Selectable = iGBool.False;
            col.CellStyle.TextAlign = iGContentAlignment.MiddleCenter;

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

        private void FormFPY_Load(object sender, EventArgs e)
        {
            iGrid1.CellDynamicFormatting += iGrid1_CellDynamicFormatting;
            iGrid1.AfterCommitEdit += iGrid1_AfterCommitEdit;

        }

        private void iGrid1_AfterCommitEdit(object sender, iGAfterCommitEditEventArgs e)
        {
            if (iGrid1.Cols[e.ColIndex].Key == "serialNumber")
            {
                iGrid1.CellValues[e.RowIndex, "status"] = string.IsNullOrWhiteSpace(e.NewText) ? "MISSING SN" : "OK";
            }

            textBoxPosition.Enabled = true;
        }

        private void iGrid1_CellDynamicFormatting(object sender, iGCellDynamicFormattingEventArgs e)
        {
            iGCell curCell = iGrid1.CurCell;
            if (curCell != null && curCell.RowIndex == e.RowIndex && curCell.ColIndex == e.ColIndex)
            {
                e.BackColor = Color.Yellow;
                return;
            }

            string status = (string)iGrid1.CellValues[e.RowIndex, "status"];

            if (status == "MISSING SN")
            {
                e.BackColor = Color.Red;
            }
            else if (status == "EMPTY")
            {
                e.BackColor = Color.Gray;
            }
            else if (status == "OK")
            {
                e.BackColor = Color.LightGreen;
            }
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

  
