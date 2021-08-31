using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoClicker
{
    public partial class Form2 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public bool minimizeToTray = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ApplyButton.PerformClick();
            this.Hide();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            minimizeToTray = MinimizetoTrayCheckBox.Checked;
            ApplyButton.Enabled = false;
        }

        private void MinimizetoTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }
    }
}
