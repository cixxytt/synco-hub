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
    public partial class frmSystemInfo : Form
    {
        public frmSystemInfo()
        {
            InitializeComponent();

			panel1.AutoScroll = true;
			panel1.BorderStyle = BorderStyle.FixedSingle;

			hwidLabel.Text = "" + siticoneDeviceInfo1.GetSerialNumber;
			baseboard.Text = "" + siticoneDeviceInfo1.GetManufacturer;
			label17.Text = "" + siticoneDeviceInfo1.GetManufacturerModel;

			label18.Text = "" + siticoneDeviceInfo1.GetBIOSSerialNumber;
			label20.Text = "" + siticoneDeviceInfo1.GetBIOSManufacturer;
			label22.Text = "" + siticoneDeviceInfo1.GetBIOSVersion;

			label26.Text = "" + siticoneDeviceInfo1.GetProcessorSerialNumber;
			label27.Text = "" + siticoneDeviceInfo1.GetProcessorId;

			label30.Text = "" + siticoneDeviceInfo1.GetGPUVideoProcessor;
			label31.Text = "" + siticoneDeviceInfo1.GetGPUDriverVersion;

			label40.Text = "" + siticoneDeviceInfo1.GetDNSHostName;
			label39.Text = "" + siticoneDeviceInfo1.GetSystemCaption;
			label35.Text = "" + siticoneDeviceInfo1.GetSystemUserDomainName;
			label36.Text = "" + siticoneDeviceInfo1.GetSystemUsername;
			label37.Text = "" + siticoneDeviceInfo1.GetSystemType;
			label38.Text = "" + siticoneDeviceInfo1.GetSystemMachineName;

			label41.Text = "" + siticoneDeviceInfo1.GetBatteryDeviceID;
			label42.Text = "" + siticoneDeviceInfo1.GetBatterySystemName;
			label45.Text = "" + siticoneDeviceInfo1.GetBatteryStatus;
			label46.Text = "" + siticoneDeviceInfo1.GetBatteryEstimatedRunTime;
			label44.Text = "" + siticoneDeviceInfo1.GetBatteryEstimatedChargeRemaining;
			label43.Text = "" + siticoneDeviceInfo1.GetBatteryChemistry;

			label8.Text = "" + siticoneDeviceInfo1.GetGuid;
			label25.Text = "" + siticoneDeviceInfo1.GetUniqueId;
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

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void siticoneVSeparator1_Click(object sender, EventArgs e)
		{

		}
	}
}
