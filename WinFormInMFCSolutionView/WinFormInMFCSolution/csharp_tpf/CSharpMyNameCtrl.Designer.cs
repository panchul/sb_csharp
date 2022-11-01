namespace csharp_tpf
{
    partial class CSharpMyNameCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ButtonOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(57, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(173, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // ButtonOkay
            // 
            this.ButtonOkay.Location = new System.Drawing.Point(105, 81);
            this.ButtonOkay.Name = "ButtonOkay";
            this.ButtonOkay.Size = new System.Drawing.Size(64, 25);
            this.ButtonOkay.TabIndex = 1;
            this.ButtonOkay.Text = "Okay";
            this.ButtonOkay.UseVisualStyleBackColor = true;
            this.ButtonOkay.Click += new System.EventHandler(this.ButtonOkay_Click);
            // 
            // CSharpMyNameCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonOkay);
            this.Controls.Add(this.NameTextBox);
            this.DoubleBuffered = true;
            this.Name = "CSharpMyNameCtrl";
            this.Size = new System.Drawing.Size(260, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ButtonOkay;
    }
}
