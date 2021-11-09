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
    public partial class MainForm : Form
    {
        // This lines is very important
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void MouseEvent(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        OptionsForm form2 = new OptionsForm();
        
        // Hex codes for mouse buttons
        private const int LeftUp = 0x0004;
        private const int LeftDown = 0x0002;
        private const int MiddleUp = 0x0040;
        private const int MiddleDown = 0x0020;
        private const int RightUp = 0x0010;
        private const int RightDown = 0x0008;
       
        public int MilisecondsIntervals = 100;
        public int SecondsIntervals = 0;
        public int MinutesIntervals = 0;
        public int HoursIntervals = 0;

        public bool enabled = false;

        public string ClickType = "Single";
        public string MouseButton = "Left";

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            AC.IsBackground = true;
            EnableACHotkey.RunWorkerAsync(); // Starts the AC background worker
            MinimizedNotifyIcon.Visible = false;
            form2.MinimizetoTrayCheckBox.Checked = Settings.Default.MinimizeToTray; // Loads the user settings
            form2.EnableDefaultIntervalsCheckBox.Checked = Settings.Default.EnableDefaultIntervals;
            form2.DisableTripleCheckBox.Checked = Settings.Default.DisableTriple;
            form2.EnableDefaultOptionsCheckBox.Checked = Settings.Default.EnableDefaultOptions;

            AC.Start(); // Starts AutoClick()

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

            if (Settings.Default.EnableDefaultOptions == false)
            {
                ClickTypeDropDownList.Text = "Single";
                MouseButtonDropDownList.Text = "Left";
            }
        }
        
        private void SingleClickType(int HexCodeUp, int HexCodeDown)
        {
            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(HoursIntervals.ToString().PadRight(7, '0')));
            Thread.Sleep(int.Parse(MinutesIntervals.ToString().PadRight(5, '0')));
            Thread.Sleep(int.Parse(SecondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(int.Parse(SecondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(MilisecondsIntervals);
        }

        private void DoubleClickType(int HexCodeUp, int HexCodeDown)
        {
            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(HoursIntervals.ToString().PadRight(7, '0')));
            Thread.Sleep(int.Parse(MinutesIntervals.ToString().PadRight(5, '0')));
            Thread.Sleep(int.Parse(SecondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(MilisecondsIntervals);
        }

        private void TripleClickType(int HexCodeUp, int HexCodeDown)
        {
            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);

            MouseEvent(dwFlags: HexCodeDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(int.Parse(HoursIntervals.ToString().PadRight(7, '0')));
            Thread.Sleep(int.Parse(MinutesIntervals.ToString().PadRight(5, '0')));
            Thread.Sleep(int.Parse(SecondsIntervals.ToString().PadRight(4, '0')));
            Thread.Sleep(MilisecondsIntervals);
        }

        private void AutoClick()
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (MouseButton == "Left") // Checks if MouseButtonDropDownList's text is Left
                    {
                        if (ClickType == "Single") // Checks if ClickTypeDropDownList's text is Single
                        {
                            SingleClickType(LeftUp, LeftDown);
                        }
                        else if (ClickType == "Double") // Checks if ClickTypeDropDownList's text is Double
                        {
                            DoubleClickType(LeftUp, LeftDown);
                        }
                        else if (ClickType == "Triple") // Checks if ClickTypeDropDownList's text is Triple
                        {
                            TripleClickType(LeftUp, LeftDown);
                        }
                    }
                    else if (MouseButton == "Middle") // Checks if MouseButtonDropDownList's text is Middle
                    {
                        if (ClickType == "Single")
                        {
                            SingleClickType(MiddleUp, MiddleDown);
                        }
                        else if (ClickType == "Double")
                        {
                            DoubleClickType(MiddleUp, MiddleDown);
                        }
                        else if (ClickType == "Triple")
                        {
                            TripleClickType(MiddleUp, MiddleDown);
                        }
                    }
                    else if (MouseButton == "Right") // Checks if MouseButtonDropDownList's text is Right
                    {
                        if (ClickType == "Single")
                        {
                            SingleClickType(RightUp, RightDown);
                        }
                        else if (ClickType == "Double")
                        {
                            DoubleClickType(RightUp, RightDown);
                        }
                        else if (ClickType == "Triple")
                        {
                            TripleClickType(RightUp, RightDown);
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
                StartButton.Enabled = true;
                MilisecondsIntervals = int.Parse(Miliseconds.Text); // Makes the interval's value to the text of textbox interval's
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
                StartButton.Enabled = true;
                SecondsIntervals = int.Parse(Seconds.Text);
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
                    StartButton.Enabled = true;
                    MinutesIntervals = int.Parse(Minutes.Text) + 5;
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
                if (int.Parse(Hours.Text) != 0)
                {
                    StartButton.Enabled = true;
                    HoursIntervals = int.Parse(Hours.Text) + 5;
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

        private void MouseButtonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MouseButton = MouseButtonDropDownList.Text;
        }

        private void ClickTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClickType = ClickTypeDropDownList.Text;
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
    }
}
