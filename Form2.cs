using autoClicker.Properties;
using autoClicker2;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

namespace autoClicker
{

    public partial class OptionsForm : Form
    {
        public static MainForm mainForm = new MainForm();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = createParams.ClassStyle | 0x200;
                return createParams;
            }
        }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EnableDefaultIntervalsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableDefaultIntervals = EnableDefaultIntervalsCheckBox.Checked;

            if (Settings.Default.EnableDefaultIntervals == true)
            {
                EDIHours.Enabled = true;
                EDIMinutes.Enabled = true;
                EDISeconds.Enabled = true;
                EDIMiliseconds.Enabled = true;
                EDIHoursLabel.Enabled = true;
                EDIMinutesLabel.Enabled = true;
                EDISecondsLabel.Enabled = true;
                EDIMilisecondsLabel.Enabled = true;
            } else
            {
                EDIHours.Enabled = false;
                EDIMinutes.Enabled = false;
                EDISeconds.Enabled = false;
                EDIMiliseconds.Enabled = false;
                EDIHoursLabel.Enabled = false;
                EDIMinutesLabel.Enabled = false;
                EDISecondsLabel.Enabled = false;
                EDIMilisecondsLabel.Enabled = false;
                EDIHours.Text = "0";
                EDIMinutes.Text = "0";
                EDISeconds.Text = "0";
                EDIMiliseconds.Text = "100";
            }
        }

        private void EnableDefaultOptionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableDefaultOptions = EnableDefaultOptionsCheckBox.Checked;

            if (Settings.Default.EnableDefaultOptions == true)
            {
                EDOMouseButtonDropDownList.Enabled = true;
                EDOClickTypeDropDownList.Enabled = true;
                EDOMouseButtonLabel.Enabled = true;
                EDOClickTypeLabel.Enabled = true;
            } else
            {
                EDOMouseButtonDropDownList.Enabled = false;
                EDOClickTypeDropDownList.Enabled = false;
                EDOMouseButtonLabel.Enabled = false;
                EDOClickTypeLabel.Enabled = false;
            }
        }

        private void MinimizetoTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.MinimizeToTray = MinimizetoTrayCheckBox.Checked;
        }

        private void StartMinimizedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.StartMinimized = StartMinimizedCheckBox.Checked;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();

            MinimizetoTrayCheckBox.Checked = Settings.Default.MinimizeToTray;
            EnableDefaultIntervalsCheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            EnableDefaultOptionsCheckBox.Checked = Settings.Default.EnableDefaultOptions;
            StartMinimizedCheckBox.Checked = Settings.Default.StartMinimized;

            EDOClickTypeDropDownList.Text = Settings.Default.EDOClickType;
            EDOMouseButtonDropDownList.Text = Settings.Default.EDOMouseButton;

            this.Hide();
        }

        private void EDIHours_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EDIHours.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            } else
            {
                Settings.Default.EDIHoursInterval = Convert.ToInt32(EDIHours.Text);
                if (Regex.IsMatch(EDIMinutes.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(EDISeconds.Text, @"^\d+$"))
                    {
                        if (Regex.IsMatch(EDIMiliseconds.Text, @"^\d+$"))
                        {
                            ApplyButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void EDIMinutes_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EDIMinutes.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
            else
            {
                Settings.Default.EDIMinutesInterval = Convert.ToInt32(EDIMinutes.Text);
                if (Regex.IsMatch(EDIHours.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(EDISeconds.Text, @"^\d+$"))
                    {
                        if (Regex.IsMatch(EDIMiliseconds.Text, @"^\d+$"))
                        {
                            ApplyButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void EDISeconds_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EDISeconds.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
            else
            {
                Settings.Default.EDISecondsInterval = Convert.ToInt32(EDISeconds.Text);
                if (Regex.IsMatch(EDIHours.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(EDIMinutes.Text, @"^\d+$"))
                    {
                        if (Regex.IsMatch(EDIMiliseconds.Text, @"^\d+$"))
                        {
                            ApplyButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void EDIMiliseconds_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EDIMiliseconds.Text, @"^\d+$"))
            {
                ApplyButton.Enabled = false;
            }
            else
            {
                Settings.Default.EDIMilisecondsInterval = Convert.ToInt32(EDIMiliseconds.Text);
                if (Regex.IsMatch(EDIHours.Text, @"^\d+$"))
                {
                    if (Regex.IsMatch(EDIMinutes.Text, @"^\d+$"))
                    {
                        if (Regex.IsMatch(EDISeconds.Text, @"^\d+$"))
                        {
                            ApplyButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void EDOMouseButtonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.EDOMouseButton = Convert.ToString(EDOMouseButtonDropDownList.SelectedItem);
        }

        private void EDOClickTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.EDOClickType = Convert.ToString(EDOClickTypeDropDownList.SelectedItem);
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            EDOMouseButtonDropDownList.Text = "Left";
            EDOClickTypeDropDownList.Text = "Single";

            if (Settings.Default.EnableDefaultOptions == true)
            {
                EDOMouseButtonDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
                EDOClickTypeDropDownList.SelectedItem = Settings.Default.EDOClickType;
            }
        }

        private void RestoreDefaultsButton_Click(object sender, EventArgs e)
        {
            StartMinimizedCheckBox.Checked = false;
            MinimizetoTrayCheckBox.Checked = false;
            EnableDefaultIntervalsCheckBox.Checked = false;
            EnableDefaultOptionsCheckBox.Checked = false;
        }
    }
}
