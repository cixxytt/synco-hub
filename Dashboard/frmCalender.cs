using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmCalender : Form
    {
        public frmCalender()
        {
            InitializeComponent();

			panel1.AutoScroll = true;
			panel1.BorderStyle = BorderStyle.FixedSingle;
		}

		private void frmCalender_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
