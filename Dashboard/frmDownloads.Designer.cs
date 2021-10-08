namespace Dashboard
{
    partial class frmDownloads
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloads));
			this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneDeviceInfo1 = new Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// siticoneButton1
			// 
			this.siticoneButton1.Animated = true;
			this.siticoneButton1.AutoRoundedCorners = true;
			this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
			this.siticoneButton1.BorderRadius = 17;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = System.Drawing.Color.MediumPurple;
			this.siticoneButton1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.siticoneButton1.ForeColor = System.Drawing.Color.White;
			this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
			this.siticoneButton1.IndicateFocus = true;
			this.siticoneButton1.Location = new System.Drawing.Point(101, 207);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new System.Drawing.Size(115, 37);
			this.siticoneButton1.TabIndex = 0;
			this.siticoneButton1.Text = "Download";
			this.siticoneButton1.UseTransparentBackground = true;
			this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Dosis", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nemesis Multitool (By zalrz)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// siticonePictureBox1
			// 
			this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.siticonePictureBox1.BorderRadius = 20;
			this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
			this.siticonePictureBox1.ImageRotate = 0F;
			this.siticonePictureBox1.Location = new System.Drawing.Point(1, 42);
			this.siticonePictureBox1.Name = "siticonePictureBox1";
			this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
			this.siticonePictureBox1.Size = new System.Drawing.Size(314, 159);
			this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox1.TabIndex = 1;
			this.siticonePictureBox1.TabStop = false;
			this.siticonePictureBox1.UseTransparentBackground = true;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(707, 9);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 464);
			this.vScrollBar1.TabIndex = 3;
			// 
			// frmDownloads
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(733, 482);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.siticonePictureBox1);
			this.Controls.Add(this.siticoneButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDownloads";
			this.Text = "frmAnalytics";
			((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
		private Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo siticoneDeviceInfo1;
		private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
	}
}