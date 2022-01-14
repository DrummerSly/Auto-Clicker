using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using autoClicker.Properties;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using autoClicker;
using System;

namespace autoClicker2 // I made an auto clicker back then but it sucks
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern int GetAsyncKeyState(Keys key);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public static OptionsForm optionsForm = new OptionsForm();

        int leftUp = 0x0004;
        int leftDown = 0x0002;
        int middleUp = 0x0040;
        int middleDown = 0x0020;
        int rightUp = 0x0010;
        int rightDown = 0x0008;

        int milisecondsIntervals = 100;
        int secondsIntervals;
        int minutesIntervals;
        int hoursIntervals;

        bool enabled = false;

        string clickType = "Single";
        string mouseButton = "Left";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread AC = new Thread(AutoClick);
            AC.IsBackground = true;

            ACBackgroundWorker.RunWorkerAsync();

            MouseButtonDropDownList.Text = "Left";
            ClickTypeDropDownList.Text = "Single";

            optionsForm.MinimizetoTrayCheckBox.Checked = Settings.Default.MinimizeToTray;
            optionsForm.EnableDefaultIntervalsCheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            optionsForm.EnableDefaultOptionsCheckBox.Checked = Settings.Default.EnableDefaultOptions;
            optionsForm.StartMinimizedCheckBox.Checked = Settings.Default.StartMinimized;

            if (Settings.Default.EnableDefaultIntervals == true)
            {
                HoursTextbox.Text = Convert.ToString(Settings.Default.EDIHoursInterval);
                MinutesTextbox.Text = Convert.ToString(Settings.Default.EDIMinutesInterval);
                SecondsTextbox.Text = Convert.ToString(Settings.Default.EDISecondsInterval);
                MilisecondsTextbox.Text = Convert.ToString(Settings.Default.EDIMilisecondsInterval);
            }

            if (Settings.Default.EnableDefaultOptions == true)
            {
                MouseButtonDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
                ClickTypeDropDownList.SelectedItem = Settings.Default.EDOClickType;
            }

            if (Settings.Default.StartMinimized == true)
            {
                this.ShowInTaskbar = false;
                MinimizedNotifyIcon.Visible = true;
                MinimizedNotifyIcon.Icon = this.Icon;
            }

            AC.Start();
        }

        void SingleClickType(int HexCodeUp, int HexCodeDown)
        {
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(hoursIntervals.ToString() + 0 + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(minutesIntervals.ToString() + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(secondsIntervals.ToString() + 0 + 0 + 0));
            Thread.Sleep(milisecondsIntervals);
        }

        void DoubleClickType(int HexCodeUp, int HexCodeDown)
        {
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(hoursIntervals.ToString() + 0 + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(minutesIntervals.ToString() + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(secondsIntervals.ToString() + 0 + 0 + 0));
            Thread.Sleep(milisecondsIntervals);
        }

        void TripleClickType(int HexCodeUp, int HexCodeDown)
        {
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            mouse_event(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(hoursIntervals.ToString() + 0 + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(minutesIntervals.ToString() + 0 + 0 + 0 + 0));
            Thread.Sleep(int.Parse(secondsIntervals.ToString() + 0 + 0 + 0));
            Thread.Sleep(milisecondsIntervals);
        }

        void AutoClick()
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (mouseButton == "Left")
                    {
                        if (clickType == "Single")
                        {
                            SingleClickType(leftUp, leftDown);
                        }
                        else if (clickType == "Double")
                        {
                            DoubleClickType(leftUp, leftDown);
                        }
                        else if (clickType == "Triple")
                        {
                            TripleClickType(leftUp, leftDown);
                        }
                    }
                    else if (mouseButton == "Middle")
                    {
                        if (clickType == "Single")
                        {
                            SingleClickType(middleUp, middleDown);
                        }
                        else if (clickType == "Double")
                        {
                            DoubleClickType(middleUp, middleDown);
                        }
                        else if (clickType == "Triple")
                        {
                            TripleClickType(middleUp, middleDown);
                        }
                    }
                    else if (mouseButton == "Right")
                    {
                        if (clickType == "Single")
                        {
                            SingleClickType(rightUp, rightDown);
                        }
                        else if (clickType == "Double")
                        {
                            DoubleClickType(rightUp, rightDown);
                        }
                        else if (clickType == "Triple")
                        {
                            TripleClickType(rightUp, rightDown);
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            enabled = true;
            StopButton.Enabled = true;

            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            enabled = false;
            StopButton.Enabled = false;
        }

        private void Miliseconds_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(MilisecondsTextbox.Text, @"^\d+$"))
            {
                StartButton.Enabled = false;
            }
            else
            {
                milisecondsIntervals = Convert.ToInt32(MilisecondsTextbox.Text);
                //Console.WriteLine(milisecondsIntervals);
                if (Regex.IsMatch(HoursTextbox.Text, @"^\d+$") && Regex.IsMatch(MinutesTextbox.Text, @"^\d+$") && Regex.IsMatch(SecondsTextbox.Text, @"^\d+$"))
                {
                    StartButton.Enabled = true;
                }
            }
        }
        
        private void Seconds_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(SecondsTextbox.Text, @"^\d+$"))
            {
                StartButton.Enabled = false;
            }
            else
            {
                secondsIntervals = Convert.ToInt32(SecondsTextbox.Text);
                //Console.WriteLine(secondsIntervals);
                if (Regex.IsMatch(HoursTextbox.Text, @"^\d+$") && Regex.IsMatch(MinutesTextbox.Text, @"^\d+$") && Regex.IsMatch(MilisecondsTextbox.Text, @"^\d+$"))
                {
                    StartButton.Enabled = true;
                }
            }
        }

        private void Minutes_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(MinutesTextbox.Text, @"^\d+$"))
            {
                StartButton.Enabled = false;
            }
            else
            {
                if (int.Parse(MinutesTextbox.Text) != 0)
                {
                    minutesIntervals = Convert.ToInt32(MinutesTextbox.Text) + 5;
                    //Console.WriteLine(minutesIntervals);
                    if (Regex.IsMatch(HoursTextbox.Text, @"^\d+$") && Regex.IsMatch(SecondsTextbox.Text, @"^\d+$") && Regex.IsMatch(MilisecondsTextbox.Text, @"^\d+$"))
                    {
                        StartButton.Enabled = true;
                    }
                }
            }
        }

        private void Hours_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(HoursTextbox.Text, @"^\d+$"))
            {
                StartButton.Enabled = false;
            }
            else
            {
                if (int.Parse(HoursTextbox.Text) != 0)
                {
                    hoursIntervals = Convert.ToInt32(HoursTextbox.Text) + 35;
                    //Console.WriteLine(hoursIntervals);
                    if (Regex.IsMatch(MinutesTextbox.Text, @"^\d+$") && Regex.IsMatch(SecondsTextbox.Text, @"^\d+$") && Regex.IsMatch(MilisecondsTextbox.Text, @"^\d+$"))
                    {
                        StartButton.Enabled = true;
                    }
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (Settings.Default.MinimizeToTray == true)
                {
                    this.ShowInTaskbar = false;
                    MinimizedNotifyIcon.Visible = true;
                    MinimizedNotifyIcon.Icon = this.Icon;
                }
            }
        }

        private void mouseButtonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouseButton = MouseButtonDropDownList.Text;
        }

        private void clickTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickType = ClickTypeDropDownList.Text;
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            optionsForm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            MinimizedNotifyIcon.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ACBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (enabled == true && StartButton.Enabled == false)
                {
                    if (GetAsyncKeyState(Keys.F7) < 0)
                    {
                        StartButton.Enabled = true;
                        enabled = false;
                        StopButton.Enabled = false;

                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else if (enabled == false && StartButton.Enabled != false)
                {
                    if (GetAsyncKeyState(Keys.F6) < 0)
                    {
                        StartButton.Enabled = false;
                        enabled = true;
                        StopButton.Enabled = true;

                        if (this.WindowState != FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
