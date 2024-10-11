namespace BMAMTNX
{
    partial class Form1
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
            buttonShowDialog = new Button();
            SuspendLayout();
            // 
            // buttonShowDialog
            // 
            buttonShowDialog.Location = new Point(223, 179);
            buttonShowDialog.Name = "buttonShowDialog";
            buttonShowDialog.Size = new Size(392, 46);
            buttonShowDialog.TabIndex = 0;
            buttonShowDialog.Text = "Show Dialog";
            buttonShowDialog.UseVisualStyleBackColor = true;
            buttonShowDialog.Click += buttonShowDialog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowDialog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShowDialog;
    }
}
