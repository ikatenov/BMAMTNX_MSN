namespace BMAMTNX
{
    partial class FormFPY
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPosition = new TextBox();
            panel1 = new Panel();
            iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iGrid1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(145, 14);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(189, 23);
            textBoxPosition.TabIndex = 0;
            textBoxPosition.TextAlign = HorizontalAlignment.Center;
            textBoxPosition.KeyUp += textBox1_KeyUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(iGrid1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 300);
            panel1.TabIndex = 1;
            // 
            // iGrid1
            // 
            iGrid1.DefaultAutoGroupRow.Height = 21;
            iGrid1.DefaultRow.Height = 21;
            iGrid1.DefaultRow.NormalCellHeight = 21;
            iGrid1.Dock = DockStyle.Fill;
            iGrid1.EnsureVisibleAutoHScroll = false;
            iGrid1.EnsureVisibleAutoVScroll = false;
            iGrid1.Location = new Point(0, 0);
            iGrid1.Margin = new Padding(2, 1, 2, 1);
            iGrid1.Name = "iGrid1";
            iGrid1.Size = new Size(464, 300);
            iGrid1.TabIndex = 1;
            // 
            // FormFPY
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 370);
            Controls.Add(panel1);
            Controls.Add(textBoxPosition);
            Name = "FormFPY";
            Text = "Form1";
            Load += FormFPY_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPosition;
        private Panel panel1;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
    }
}
