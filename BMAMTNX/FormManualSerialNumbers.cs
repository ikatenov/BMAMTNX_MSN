using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMAMTNX
{
    public partial class FormManualSerialNumbers : Form
    {
        int NumMeters;
        public FormManualSerialNumbers()
        {
            InitializeComponent();
        }

        public void Show(string title, int numMeters)
        {
            this.Text = title;

            NumMeters = numMeters;
           
            this.Show();
        }


        public class DataEnteredEventArgs : EventArgs
        {
            public string[] Data { get; }

            public DataEnteredEventArgs(string[] data)
            {
                Data = data;
            }
        }

    }
}
