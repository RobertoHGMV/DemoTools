using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTools.Forms
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var fcpu = pCPU.NextValue();
            var fram = pRam.NextValue();
            progressCPU.Value = (int)fcpu;
            progressRam.Value = (int)fram;
            lbPercentCPU.Text = string.Format("{0:0.00}%", fcpu);
            lbPercentRam.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }
    }
}
