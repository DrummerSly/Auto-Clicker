using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using autoClicker;
using autoClicker.Properties;

namespace autoClicker2
{
    public partial class Form1 : Form
    {
        // This lines is very important
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        Form2 form2 = new Form2();
        
        // Hex codes for mouse buttons
        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        private const int MIDDLEUP = 0x0040;
        private const int MIDDLEDOWN = 0x0020;
        private const int RIGHTUP = 0x0010;
        private const int RIGHTDOWN = 0x0008;
       
        public int milisecondsIntervals = 100;
        public int secondsIntervals = 0;
        public int minutesIntervals = 0;
        public int hoursIntervals = 0;

        public bool enabled = false;

        public string clickType = "Single";
        public string mouseButton = "Left";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            AC.IsBackground = true;
            EnableACHotkey.RunWorkerAsync(); // Starts the AC background worker
            ClickTypeDropDownList.Text = "Single";
            MouseButtonDropDownList.Text = "Left";
            MinimizedNotifyIcon.Visible = false;
            form2.MinimizetoTrayCheckBox.Checked = Settings.Default.MinimizeToTray; // Loads the user settings
            form2.EnableDefaultIntervalsCheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            form2.DisableTripleCheckBox.Checked = Settings.Default.DisableTriple;
            form2.EnableDefaultOptionsCheckBox.Checked = Settings.Default.EnableDefaultOptions;

            if (form2.disableTriple == true)
            {
                ClickTypeDropDownList.Items.Remove("Triple");
            }

            if (form2.enableDefaultIntervals == true)
            {
                Hours.Text = Convert.ToString(Settings.Default.EDIHoursInterval);
                Minutes.Text = Convert.ToString(Settings.Default.EDIMinutesInterval);
                Seconds.Text = Convert.ToString(Settings.Default.EDISecondsInterval);
                Miliseconds.Text = Convert.ToString(Settings.Default.EDIMilisecondsInterval);
            }

            if (form2.enableDefaultOptions == true)
            {
                MouseButtonDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
                ClickTypeDropDownList.SelectedItem = Settings.Default.EDOClickType;
            }

            AC.Start(); // Starts AutoClick()
        }

        private void SingleClickType(int HEXCODEUP, int HEXCODEDOWN)
        {
            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0); // Holds down mouse left button
            Thread.Sleep(1); // Thread.Sleep(); is basically wait() for some coding languages but it's different

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0); // Releases mouse left button
            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0'))); // Thread.Sleep(??00000); ("?" means the text you put in textbox interval's)
            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0'))); // Thread.Sleep(?0000);
            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0'))); // Thread.Sleep(?000);
            Thread.Sleep(milisecondsIntervals); // Thread.SLeep(?);
        }

        private void DoubleClickType(int HEXCODEUP, int HEXCODEDOWN)
        {
            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(milisecondsIntervals);
        }

        private void TripleClickType(int HEXCODEUP, int HEXCODEDOWN)
        {
            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            mouse_event(dwFlags: HEXCODEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(milisecondsIntervals);
        }

        private void AutoClick()
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (mouseButton == "Left") // Checks if MouseButtonDropDownList's text is Left
                    {
                        if (clickType == "Single") // Checks if ClickTypeDropDownList's text is Single
                        {
                            SingleClickType(LEFTUP, LEFTDOWN);
                        }
                        else if (clickType == "Double") // Checks if ClickTypeDropDownList's text is Double
                        {
                            DoubleClickType(LEFTUP, LEFTDOWN);
                        }
                        else if (clickType == "Triple") // Checks if ClickTypeDropDownList's text is Triple
                        {
                            TripleClickType(LEFTUP, LEFTDOWN);
                        }
                    }
                    else if (mouseButton == "Middle") // Checks if MouseButtonDropDownList's text is Middle
                    {
                        if (clickType == "Single")
                        {
                            SingleClickType(MIDDLEUP, MIDDLEDOWN);
                        }
                        else if (clickType == "Double")
                        {
                            DoubleClickType(MIDDLEUP, MIDDLEDOWN);
                        }
                        else if (clickType == "Triple")
                        {
                            TripleClickType(MIDDLEUP, MIDDLEDOWN);
                        }
                    }
                    else if (mouseButton == "Right") // Checks if MouseButtonDropDownList's text is Right
                    {
                        if (clickType == "Single")
                        {
                            SingleClickType(RIGHTUP, RIGHTDOWN);
                        }
                        else if (clickType == "Double")
                        {
                            DoubleClickType(RIGHTUP, RIGHTDOWN);
                        }
                        else if (clickType == "Triple")
                        {
                            TripleClickType(RIGHTUP, RIGHTDOWN);
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
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            enabled = false;
            StopButton.Enabled = false;
        }

        private void Miliseconds_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Miliseconds.Text, @"^\d+$"))
            {
                milisecondsIntervals = int.Parse(Miliseconds.Text); // Makes the interval's value to the text of textbox interval's
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void Seconds_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Miliseconds.Text, @"^\d+$"))
            {
                secondsIntervals = int.Parse(Seconds.Text);
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void Minutes_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Minutes.Text, @"^\d+$"))
            {
                if (int.Parse(Minutes.Text) != 0) // Checks if the numeric isn't 0
                {
                    minutesIntervals = int.Parse(Minutes.Text) + 5;
                }
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void Hours_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Hours.Text, @"^\d+$"))
            {
                if (int.Parse(Hours.Text) != 0) // Checks if the numeric isn't 0
                {
                    hoursIntervals = int.Parse(Hours.Text) + 5;
                }
            }
            else
            {
                StartButton.Enabled = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (GetAsyncKeyState(Keys.F7) < 0) // Checks if you pressed F7
                    {
                        StartButton.Enabled = true;
                        enabled = false;
                        StopButton.Enabled = false;
                    }
                } else if (enabled == false)
                {
                    if (GetAsyncKeyState(Keys.F6) < 0)
                    {
                        StartButton.Enabled = false;
                        enabled = true;
                        StopButton.Enabled = true;
                    }    
                }
                Thread.Sleep(1);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) // Checks if the window is minimized
            {           
                if (form2.minimizeToTray == true) // Checks if minimizeToTray's value is true
                {
                    this.ShowInTaskbar = false;
                    MinimizedNotifyIcon.Visible = true;
                    MinimizedNotifyIcon.Icon = this.Icon;
                }
            }
        }

        private void MinimizedNotifyIcon_MouseClick(object sender, MouseEventArgs e) // If they pressed the notify icon
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            MinimizedNotifyIcon.Visible = false;
        }

        private void MouseButtonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouseButton = MouseButtonDropDownList.Text;
        }

        private void ClickTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickType = ClickTypeDropDownList.Text;
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();

            if (form2.disableTriple == true)
            {
                if (Convert.ToBoolean(form2.EDOClickTypeDropDownList.Items.IndexOf("Triple") != -1)) // Check if "Triple" is still in the list
                {
                    form2.EDOClickTypeDropDownList.Items.Remove("Triple");
                }
            } else
            {
                if (Convert.ToBoolean(form2.EDOClickTypeDropDownList.Items.IndexOf("Triple") != -1))
                {
                    return;
                }
                form2.EDOClickTypeDropDownList.Items.Add("Triple");
            }
        }
    }
}
