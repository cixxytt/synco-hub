using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmDownloads : Form
    {
        public frmDownloads()
        {
            InitializeComponent();
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
	}
}
