using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTools.Forms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        SettingsUserControl _settings = new SettingsUserControl();

        public MainForm()
        {
            InitializeComponent();
        }

        private void linkMain_Click(object sender, EventArgs e)
        {
            _settings.Visible = false;
        }

        private void linkSettings_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Add(_settings);
            _settings.Dock = DockStyle.Fill;
            _settings.Visible = true;
            _settings.Show();
        }
    }
}
