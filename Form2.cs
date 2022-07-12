using AutoClicker.Properties;
using System.Windows.Forms;
using System;

namespace AutoClicker
{
    public partial class Form2 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = createParams.ClassStyle | 0x200;
                return createParams;
            }
        }

        Form form1;

        int ediHInput;
        int ediMInput;
        int ediSInput;
        int ediMiInput;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            form1 = parentForm;
        }

        private void EDOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EDOCheckBox.Checked == false)
            {
                EDOMBDropDownList.Text = "Left";
                EDOCTDropDownList.Text = "Single";
            }

            Settings.Default.EnableDefaultOptions = EDOCheckBox.Checked;
            EDOMBLabel.Enabled = !EDOMBLabel.Enabled;
            EDOCTLabel.Enabled = !EDOCTLabel.Enabled;
            EDOMBDropDownList.Enabled = !EDOMBDropDownList.Enabled;
            EDOCTDropDownList.Enabled = !EDOCTDropDownList.Enabled;
        }

        private void EDICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EDICheckBox.Checked == false)
            {
                EDIHours.Text = "0";
                EDIMinutes.Text = "0";
                EDISeconds.Text = "0";
                EDIMiliseconds.Text = "100";
            }

            Settings.Default.EnableDefaultIntervals = EDICheckBox.Checked;
            EDIHoursLabel.Enabled = !EDIHoursLabel.Enabled;
            EDIMinutesLabel.Enabled = !EDIMinutesLabel.Enabled;
            EDISecondsLabel.Enabled = !EDISecondsLabel.Enabled;
            EDIMilisecondsLabel.Enabled = !EDIMilisecondsLabel.Enabled;
            EDIHours.Enabled = !EDIHours.Enabled;
            EDIMinutes.Enabled = !EDIMinutes.Enabled;
            EDISeconds.Enabled = !EDISeconds.Enabled;
            EDIMiliseconds.Enabled = !EDIMiliseconds.Enabled;
        }

        private void MtTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.MinimizeToTray = MtTCheckBox.Checked;
        }

        private void EDIHours_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(EDIHours.Text, out ediHInput))
            {
                Settings.Default.EDIHoursInterval = ediHInput;
            }
            else
            {
                EDIHours.Text = "";
            }
        }

        private void EDIMinutes_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(EDIMinutes.Text, out ediMInput))
            {
                Settings.Default.EDIMinutesInterval = ediMInput;
            }
            else
            {
                EDIMinutes.Text = "";
            }
        }

        private void EDISeconds_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(EDISeconds.Text, out ediSInput))
            {
                Settings.Default.EDISecondsInterval = ediSInput;
            }
            else
            {
                EDISeconds.Text = "";
            }
        }

        private void EDIMiliseconds_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(EDIMiliseconds.Text, out ediMiInput))
            {
                Settings.Default.EDIMilisecondsInterval = ediMiInput;
            }
            else
            {
                EDIMiliseconds.Text = "";
            }
        }

        private void EDOMBDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.EDOMouseButton = EDOMBDropDownList.Text;
        }

        private void EDOCTDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.EDOClickType = EDOCTDropDownList.Text;
        }

        private void DSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DisplayStatus = DSCheckBox.Checked;
        }

        private void KPoTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.KeepWindowOnTop = KPoTCheckBox.Checked;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.KeepWindowOnTop == true)
            {
                form1.TopMost = true;
                this.TopMost = false;
            }

            Settings.Default.Save();
            this.Hide();
            form1.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Settings.Default.KeepWindowOnTop == true)
            {
                form1.TopMost = false;
                this.TopMost = true;
            }
            
            EDOMBDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
            EDOCTDropDownList.SelectedItem = Settings.Default.EDOClickType;

            DSCheckBox.Checked = Settings.Default.DisplayStatus;
            MtTCheckBox.Checked = Settings.Default.MinimizeToTray;
            KPoTCheckBox.Checked = Settings.Default.KeepWindowOnTop;
            EDICheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            EDOCheckBox.Checked = Settings.Default.EnableDefaultOptions;

            EDIHours.Text = Settings.Default.EDIHoursInterval.ToString();
            EDIMinutes.Text = Settings.Default.EDIMinutesInterval.ToString();
            EDISeconds.Text = Settings.Default.EDISecondsInterval.ToString();
            EDIMiliseconds.Text = Settings.Default.EDIMilisecondsInterval.ToString();
        }
    }
}
