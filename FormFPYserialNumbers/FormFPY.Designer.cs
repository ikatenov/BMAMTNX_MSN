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
            iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelTextBox = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)iGrid1).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(279, 6);
            textBoxPosition.Margin = new Padding(6);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(348, 39);
            textBoxPosition.TabIndex = 0;
            textBoxPosition.TextAlign = HorizontalAlignment.Center;
            textBoxPosition.KeyUp += textBox1_KeyUp;
            // 
            // iGrid1
            // 
            iGrid1.DefaultAutoGroupRow.Height = 38;
            iGrid1.DefaultRow.Height = 38;
            iGrid1.DefaultRow.NormalCellHeight = 38;
            iGrid1.Dock = DockStyle.Fill;
            iGrid1.EnsureVisibleAutoHScroll = false;
            iGrid1.EnsureVisibleAutoVScroll = false;
            iGrid1.Header.Height = 35;
            iGrid1.Location = new Point(4, 82);
            iGrid1.Margin = new Padding(4, 2, 4, 2);
            iGrid1.Name = "iGrid1";
            iGrid1.Size = new Size(905, 705);
            iGrid1.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(iGrid1, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelTextBox, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(906, 789);
            tableLayoutPanelMain.TabIndex = 2;
            // 
            // tableLayoutPanelTextBox
            // 
            tableLayoutPanelTextBox.ColumnCount = 3;
            tableLayoutPanelTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.Controls.Add(textBoxPosition, 1, 0);
            tableLayoutPanelTextBox.Dock = DockStyle.Fill;
            tableLayoutPanelTextBox.Location = new Point(3, 3);
            tableLayoutPanelTextBox.Name = "tableLayoutPanelTextBox";
            tableLayoutPanelTextBox.RowCount = 1;
            tableLayoutPanelTextBox.RowStyles.Add(new RowStyle());
            tableLayoutPanelTextBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTextBox.Size = new Size(907, 74);
            tableLayoutPanelTextBox.TabIndex = 2;
            // 
            // FormFPY
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 789);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(6);
            Name = "FormFPY";
            Text = "Form1";
            Load += FormFPY_Load;
            ((System.ComponentModel.ISupportInitialize)iGrid1).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelTextBox.ResumeLayout(false);
            tableLayoutPanelTextBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxPosition;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelTextBox;
    }
}
