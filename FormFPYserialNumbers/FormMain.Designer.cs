namespace BMAMTNX
{
    partial class FormMain
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
            ButtonTest1 = new Button();
            SuspendLayout();
            // 
            // ButtonTest1
            // 
            ButtonTest1.Location = new Point(75, 55);
            ButtonTest1.Margin = new Padding(2, 1, 2, 1);
            ButtonTest1.Name = "ButtonTest1";
            ButtonTest1.Size = new Size(249, 30);
            ButtonTest1.TabIndex = 0;
            ButtonTest1.Text = "Enable Manual Scanning Serial Numbers";
            ButtonTest1.UseVisualStyleBackColor = true;
            ButtonTest1.Click += ButtonTest1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(ButtonTest1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonTest1;
    }
}
