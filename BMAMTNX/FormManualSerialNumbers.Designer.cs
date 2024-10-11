namespace BMAMTNX
{
    partial class FormManualSerialNumbers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            txtBoxPosition = new TextBox();
            lbl_position = new Label();
            ((System.ComponentModel.ISupportInitialize)iGrid1).BeginInit();
            SuspendLayout();
            // 
            // iGrid1
            // 
            iGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iGrid1.DefaultAutoGroupRow.Height = 21;
            iGrid1.DefaultRow.Height = 21;
            iGrid1.DefaultRow.NormalCellHeight = 21;
            iGrid1.Location = new Point(41, 92);
            iGrid1.Margin = new Padding(2, 1, 2, 1);
            iGrid1.Name = "iGrid1";
            iGrid1.Size = new Size(160, 332);
            iGrid1.TabIndex = 1;
            // 
            // txtBoxPosition
            // 
            txtBoxPosition.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPosition.Location = new Point(37, 49);
            txtBoxPosition.Name = "txtBoxPosition";
            txtBoxPosition.Size = new Size(164, 39);
            txtBoxPosition.TabIndex = 2;
            //txtBoxPosition.KeyUp += this.txtBoxPosition_KeyUp;
            // 
            // lbl_position
            // 
            lbl_position.AutoSize = true;
            lbl_position.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_position.Location = new Point(37, 10);
            lbl_position.Name = "lbl_position";
            lbl_position.Size = new Size(178, 30);
            lbl_position.TabIndex = 3;
            lbl_position.Text = "METER POSITION";
            // 
            // FormManualSerialNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 434);
            Controls.Add(lbl_position);
            Controls.Add(txtBoxPosition);
            Controls.Add(iGrid1);
            Name = "FormManualSerialNumbers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TenTec.Windows.iGridLib.iGrid iGrid1;
        private TextBox txtBoxPosition;
        private Label lbl_position;
    }
}