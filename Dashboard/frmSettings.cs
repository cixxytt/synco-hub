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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }


        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.DarkGray);
                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }
    }
}
