using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Net;
using System.IO;

namespace Dashboard
{
	public partial class Splash : Form
	{

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn
		(
		int nLeftRect,
		int nTopRect,
		int RightRect,
		int nBottomRect,
		int nWidthEllipse,
		int nHeightEllipse
		);

		public Splash()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
			circularProgressBar1.Value = 0;
		}

		private void Splash_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			circularProgressBar1.Value += 1;
			circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

			if (circularProgressBar1.Value == 1)
			{
				loadingLabel.Text = "Pasting source codes...";
			}
			if (circularProgressBar1.Value == 30)
			{
				loadingLabel.Text = "Kissing zalrz...";
			}
			if (circularProgressBar1.Value == 60)
			{
				loadingLabel.Text = "Bullying skids...";
			}
			if (circularProgressBar1.Value == 90)
			{
				loadingLabel.Text = "Stealing code from Fluyd...";
			}


			if (circularProgressBar1.Value == 100)
			{
				timer1.Enabled = false;
				Form1 main = new Form1();
				Splash splash = new Splash();
				main.Show();
				splash.Close();
			}
		}

		private void circularProgressBar1_Click(object sender, EventArgs e)
		{

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}
	}
}
