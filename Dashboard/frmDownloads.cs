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
    public partial class frmDownloads : Form
    {
        public frmDownloads()
        {
            InitializeComponent();

            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
            {
                FileName = "https://anonfiles.com/F9p1u61fu6/Nemesis_v1.1_rar",
                UseShellExecute = true
            });
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/A7HKX44A6c",
                UseShellExecute = true
            });
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
            
        }

		private void siticoneButton2_Click(object sender, EventArgs e)
		{

		}
	}
}
