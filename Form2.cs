using autoClicker.Properties;
using autoClicker2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoClicker
{
    public partial class Form2 : Form
    {
        public bool minimizeToTray = Settings.Default.MinimizeToTray;
        public bool enableDefaultIntervals = Settings.Default.EnableDefaultIntervals;
        public bool enableDefaultOptions = Settings.Default.EnableDefaultOptions;

        public bool disableTriple = Settings.Default.DisableTriple;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }   

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizetoTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MinimizetoTrayCheckBox.Checked == minimizeToTray)
            {
                ApplyButton.Enabled = false;
            } else if (MinimizetoTrayCheckBox.Checked != minimizeToTray)
            {
                ApplyButton.Enabled = true;
            }
        }

        private void EnableDefaultIntervalsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDefaultIntervalsCheckBox.Checked == enableDefaultIntervals)
            {
                ApplyButton.Enabled = false;
            }
            else if (EnableDefaultIntervalsCheckBox.Checked != enableDefaultIntervals)
            {
                ApplyButton.Enabled = true;
            }

            if (EnableDefaultIntervalsCheckBox.Checked == true)
            {
                EDIHours.Enabled = true;
                EDIMinutes.Enabled = true;
                EDISeconds.Enabled = true;
                EDIMiliseconds.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
            else if (EnableDefaultIntervalsCheckBox.Checked == false)
            {
                EDIHours.Enabled = false;
                EDIMinutes.Enabled = false;
                EDISeconds.Enabled = false;
                EDIMiliseconds.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                EDIHours.Text = "0";
                EDIMinutes.Text = "0";
                EDISeconds.Text = "0";
                EDIMiliseconds.Text = "100";
            }
        }

        private void EnableDefaultOptionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDefaultOptionsCheckBox.Checked == enableDefaultOptions)
            {   
                ApplyButton.Enabled = false;
            }
            else if (EnableDefaultOptionsCheckBox.Checked != enableDefaultOptions)
            {
                ApplyButton.Enabled = true;
            }

            if (EnableDefaultOptionsCheckBox.Checked == true)
            {
                EDOMouseButtonDropDownList.Enabled = true;
                EDOClickTypeDropDownList.Enabled = true;
                label7.Enabled = true;
                label1.Enabled = true;
            }
            else if (EnableDefaultOptionsCheckBox.Checked == false)
            {
                EDOMouseButtonDropDownList.Enabled = false;
                EDOClickTypeDropDownList.Enabled = false;
                label7.Enabled = false;
                label1.Enabled = false;
                EDOMouseButtonDropDownList.SelectedItem = "Left";
                EDOClickTypeDropDownList.SelectedItem = "Single";
            }
        }

        private void DisableTripleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DisableTripleCheckBox.Checked == disableTriple)
            {
                ApplyButton.Enabled = false;
            }
            else if (DisableTripleCheckBox.Checked != disableTriple)
            {
                ApplyButton.Enabled = true;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings.Default.MinimizeToTray = MinimizetoTrayCheckBox.Checked; // Replaces the old value to the new value
            Settings.Default.EnableDefaultIntervals = EnableDefaultIntervalsCheckBox.Checked;
            Settings.Default.DisableTriple = DisableTripleCheckBox.Checked;
            Settings.Default.EnableDefaultOptions = EnableDefaultOptionsCheckBox.Checked;
            Settings.Default.EDIHoursInterval = Convert.ToInt32(EDIHours.Text);
            Settings.Default.EDIMinutesInterval = Convert.ToInt32(EDIMinutes.Text);
            Settings.Default.EDISecondsInterval = Convert.ToInt32(EDISeconds.Text);
            Settings.Default.EDIMilisecondsInterval = Convert.ToInt32(EDIMiliseconds.Text);
            Settings.Default.EDOMouseButton = Convert.ToString(EDOMouseButtonDropDownList.SelectedItem);
            Settings.Default.EDOClickType = Convert.ToString(EDOClickTypeDropDownList.SelectedItem);
            MinimizetoTrayCheckBox.Checked = Settings.Default.MinimizeToTray;
            EnableDefaultIntervalsCheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            DisableTripleCheckBox.Checked = Settings.Default.DisableTriple;
            EnableDefaultOptionsCheckBox.Checked = Settings.Default.EnableDefaultOptions;
            Settings.Default.Save(); // Saves the current values

            EDOMouseButtonDropDownList.Text = Settings.Default.EDOMouseButton;
            EDOClickTypeDropDownList.Text = Settings.Default.EDOClickType;

            minimizeToTray = Settings.Default.MinimizeToTray;
            enableDefaultIntervals = Settings.Default.EnableDefaultIntervals;
            disableTriple = Settings.Default.DisableTriple;
            enableDefaultOptions = Settings.Default.EnableDefaultOptions;

            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (MinimizetoTrayCheckBox.Checked == minimizeToTray)
            {
                ApplyButton.Enabled = false;
            }
            else if (MinimizetoTrayCheckBox.Checked != minimizeToTray)
            {
                ApplyButton.Enabled = true;
            }

            if (EnableDefaultIntervalsCheckBox.Checked == enableDefaultIntervals)
            {
                ApplyButton.Enabled = false;
            }
            else if (EnableDefaultIntervalsCheckBox.Checked != enableDefaultIntervals)
            {
                ApplyButton.Enabled = true;
            }

            if (DisableTripleCheckBox.Checked == disableTriple)
            {
                ApplyButton.Enabled = false;
            }
            else if (DisableTripleCheckBox.Checked != disableTriple)
            {
                ApplyButton.Enabled = true;
            }

            if (EnableDefaultOptionsCheckBox.Checked == enableDefaultOptions)
            {
                ApplyButton.Enabled = false;
            }
            else if (EnableDefaultOptionsCheckBox.Checked != enableDefaultOptions)
            {
                ApplyButton.Enabled = true;
            }

            EDIHours.Text = Convert.ToString(Settings.Default.EDIHoursInterval);
            EDIMinutes.Text = Convert.ToString(Settings.Default.EDIMinutesInterval);
            EDISeconds.Text = Convert.ToString(Settings.Default.EDISecondsInterval);
            EDIMiliseconds.Text = Convert.ToString(Settings.Default.EDIMilisecondsInterval);
            EDOMouseButtonDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
            EDOClickTypeDropDownList.SelectedItem = Settings.Default.EDOClickType;

            if (Settings.Default.EnableDefaultOptions == false)
            {
                EDOClickTypeDropDownList.Text = "Single"; // Due to Visual Studio not letting me add a text in a drop down list, this line exists
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            if (MinimizetoTrayCheckBox.Checked != minimizeToTray)
            {
                MinimizetoTrayCheckBox.Checked = minimizeToTray;
            }

            if (EnableDefaultIntervalsCheckBox.Checked != enableDefaultIntervals)
            {
                EnableDefaultIntervalsCheckBox.Checked = enableDefaultIntervals;
            }

            if (DisableTripleCheckBox.Checked != disableTriple)
            {
                DisableTripleCheckBox.Checked = disableTriple;
            }

            if (EnableDefaultOptionsCheckBox.Checked != enableDefaultOptions)
            {
                EnableDefaultOptionsCheckBox.Checked = enableDefaultOptions;
            }

            if (EDIHours.Text != Convert.ToString(Settings.Default.EDIHoursInterval))
            {
                EDIHours.Text = Convert.ToString(Settings.Default.EDIHoursInterval);
            }

            if (EDIMinutes.Text != Convert.ToString(Settings.Default.EDIMinutesInterval))
            {
                EDIMinutes.Text = Convert.ToString(Settings.Default.EDIMinutesInterval);
            }

            if (EDISeconds.Text != Convert.ToString(Settings.Default.EDISecondsInterval))
            {
                EDISeconds.Text = Convert.ToString(Settings.Default.EDISecondsInterval);
            }

            if (EDIMiliseconds.Text != Convert.ToString(Settings.Default.EDIMilisecondsInterval))
            {
                EDIMiliseconds.Text = Convert.ToString(Settings.Default.EDIMilisecondsInterval);
            }

            if (Convert.ToString(EDOMouseButtonDropDownList.SelectedItem) != Settings.Default.EDOMouseButton)
            {
                EDOMouseButtonDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
            }

            if (Convert.ToString(EDOClickTypeDropDownList.SelectedItem) != Settings.Default.EDOClickType)
            {
                EDOClickTypeDropDownList.SelectedItem = Settings.Default.EDOClickType;
            }
        }

        private void EDIHours_TextChanged(object sender, EventArgs e)
        {
            if (EDIHours.Text == Convert.ToString(Settings.Default.EDIHoursInterval))
            {
                ApplyButton.Enabled = false;
            }
            else if (EDIHours.Text != Convert.ToString(Settings.Default.EDIHoursInterval))
            {
                ApplyButton.Enabled = true;
            }

            if (!Regex.IsMatch(EDIHours.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
        }

        private void EDIMinutes_TextChanged(object sender, EventArgs e)
        {
            if (EDIMinutes.Text == Convert.ToString(Settings.Default.EDIMinutesInterval))
            {
                ApplyButton.Enabled = false;
            }
            else if (EDIMinutes.Text != Convert.ToString(Settings.Default.EDIMinutesInterval))
            {
                ApplyButton.Enabled = true;
            }

            if (!Regex.IsMatch(EDIMinutes.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
        }

        private void EDISeconds_TextChanged(object sender, EventArgs e)
        {
            if (EDISeconds.Text == Convert.ToString(Settings.Default.EDISecondsInterval))
            {
                ApplyButton.Enabled = false;
            }
            else if (EDISeconds.Text != Convert.ToString(Settings.Default.EDISecondsInterval))
            {
                ApplyButton.Enabled = true;
            }

            if (!Regex.IsMatch(EDISeconds.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
        }

        private void EDIMiliseconds_TextChanged(object sender, EventArgs e)
        {
            if (EDIMiliseconds.Text == Convert.ToString(Settings.Default.EDIMilisecondsInterval))
            {
                ApplyButton.Enabled = false;
            }
            else if (EDIMiliseconds.Text != Convert.ToString(Settings.Default.EDIMilisecondsInterval))
            {
                ApplyButton.Enabled = true;
            }

            if (!Regex.IsMatch(EDIMiliseconds.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
        }

        private void EnableDefaultIntervalsCheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(EnableDefaultIntervalsCheckBox, "If enabled, you can set your own intervals so that the next time\nyou open the application. The default intervals will turn into\nyour preferred intervals. (Restart the application to take changes)");
        }

        private void MinimizetoTrayCheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(MinimizetoTrayCheckBox, "If enabled, minimizing the application will hide in taskbar windows\nand goes into the taskbar at the right side.");
        }

        private void DisableTripleCheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(DisableTripleCheckBox, "If enabled, only 'Single' and 'Double' remains in the dropdown list of click type");
        }

        private void EnableDefaultOptionsCheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(EnableDefaultOptionsCheckBox, "If enabled, you can set your own click options so that\nthe next time you open the application. The default click options will\nturn into your click options. (Restart the application to take changes)");
        }

        private void EDOMouseButtonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(EDOMouseButtonDropDownList.SelectedItem) != Settings.Default.EDOMouseButton || EnableDefaultOptionsCheckBox.Checked != enableDefaultOptions)
            {
                ApplyButton.Enabled = true;
            } 
            else if (Convert.ToString(EDOMouseButtonDropDownList.SelectedItem) == Settings.Default.EDOMouseButton)
            {
                ApplyButton.Enabled = false;
            }
        }

        private void EDOClickTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(EDOClickTypeDropDownList.SelectedItem) != Settings.Default.EDOClickType || EnableDefaultOptionsCheckBox.Checked != enableDefaultOptions)
            {
                ApplyButton.Enabled = true;
            }
            else if (Convert.ToString(EDOClickTypeDropDownList.SelectedItem) == Settings.Default.EDOClickType)
            {
                ApplyButton.Enabled = false;
            }

            if (Convert.ToString(EDOClickTypeDropDownList.SelectedItem) == "")
            {
                ApplyButton.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}