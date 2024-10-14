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
            textBox1 = new TextBox();
            panel1 = new Panel();
            iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iGrid1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(iGrid1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 260);
            panel1.TabIndex = 1;
            // 
            // iGrid1
            // 
            iGrid1.DefaultAutoGroupRow.Height = 21;
            iGrid1.DefaultRow.Height = 21;
            iGrid1.DefaultRow.NormalCellHeight = 21;
            iGrid1.Dock = DockStyle.Fill;
            iGrid1.Location = new Point(0, 0);
            iGrid1.Margin = new Padding(2, 1, 2, 1);
            iGrid1.Name = "iGrid1";
            iGrid1.Size = new Size(359, 260);
            iGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 313);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
    }
}
