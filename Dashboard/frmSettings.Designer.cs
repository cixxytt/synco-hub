namespace Dashboard
{
    partial class frmSettings
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
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.siticoneRoundedButton1 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
			this.SuspendLayout();
			// 
			// siticoneRoundedButton1
			// 
			this.siticoneRoundedButton1.BorderRadius = 21;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.siticoneRoundedButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new System.Drawing.Point(111, 57);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new System.Drawing.Size(180, 45);
			this.siticoneRoundedButton1.TabIndex = 0;
			this.siticoneRoundedButton1.Text = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(733, 482);
			this.Controls.Add(this.siticoneRoundedButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSettings";
			this.Text = "frmSettings";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
	}
}