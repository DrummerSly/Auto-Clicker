using autoClicker;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace autoClicker2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        // Hex codes for mouse buttons
        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        private const int MIDDLEUP = 0x0040;
        private const int MIDDLEDOWN = 0x0020;
        private const int RIGHTUP = 0x0010;
        private const int RIGHTDOWN = 0x0008;

        // If you want to change any of these values, you can but you need to change the textbox interval's text too
        public int milisecondsIntervals = 100;
        public int secondsIntervals = 000;
        public int minutesIntervals = 0;
        public int hoursIntervals = 0;
        
        public int parsedValue; // The value to check if the character you put in textbox interval's is numeric

        public bool enabled = false;
        
        public string clickType = "Single";
        public string mouseButton = "Left";

        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick); // Converts the void to thread or something
            EnableACHotkey.RunWorkerAsync(); // Starts the AC Hotkey
            ClickTypeDropDownList.Text = "Single";
            MouseButtonDropDownList.Text = "Left";
            MinimizedNotifyIcon.Visible = false;

            AC.Start(); // Starts AutoClick()
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
                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0); // Holds down mouse left button
                            Thread.Sleep(1); // Thread.Sleep(); is basically wait() for some coding languages but it's different

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0); // Releases mouse left button
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0'))); // Thread.Sleep(??00000); ("?" means the text you put in textbox interval's
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0'))); // Thread.Sleep(?0000);
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0'))); // Thread.Sleep(?000);
                            Thread.Sleep(milisecondsIntervals); // Thread.SLeep(?);
                        } else if (clickType == "Double") // Checks if ClickTypeDropDownList's text is Double
                        {
                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        } else if (clickType == "Triple") // Checks if ClickTypeDropDownList's text is Triple
                        {
                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        }
                    }
                    else if (mouseButton == "Middle") // Checks if MouseButtonDropDownList's text is Middle
                    {
                        if (clickType == "Single")
                        {
                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        } else if (clickType == "Double")
                        {
                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        } else if (clickType == "Triple")
                        {
                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: MIDDLEDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        }
                    }
                    else if (mouseButton == "Right") // Checks if MouseButtonDropDownList's text is Right
                    {
                        if (clickType == "Single")
                        {
                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        } else if (clickType == "Double")
                        {
                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        } else if (clickType == "Triple")
                        {
                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(1);

                            mouse_event(dwFlags: RIGHTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                            Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                            Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                            Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                            Thread.Sleep(milisecondsIntervals);
                        }
                    }
                }
                Thread.Sleep(2);
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
            if (!int.TryParse(Miliseconds.Text, out parsedValue)) // Checks if the character you put in textbox interval's is numeric
            {
                MessageBox.Show("Please enter a number");
                return;
            } else
            {
                milisecondsIntervals = int.Parse(Miliseconds.Text); // Makes the interval's value to the text of textbox interval's
            }
        }

        private void Seconds_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Seconds.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a number");
                return;
            }
            else
            {
                secondsIntervals = int.Parse(Seconds.Text);
            }
        }

        private void Minutes_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Minutes.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a number");
                return;
            }
            else
            {
                if (int.Parse(Minutes.Text) != 0) // Checks if the numeric isn't 0
                {
                    minutesIntervals = int.Parse(Minutes.Text) + 5; 
                }
            }
        }

        private void Hours_TextChanged(object sender, EventArgs e)
        {      
            if (!int.TryParse(Hours.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a number");
                return;
            }
            else
            {
                if (int.Parse(Hours.Text) != 0)
                {
                    hoursIntervals = int.Parse(Hours.Text) + 35;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (GetAsyncKeyState(Keys.F7)< 0) // Checks if you pressed F7
                    {
                        StartButton.Enabled = true;
                        enabled = false;
                        StopButton.Enabled = false;
                    }
                } else if (enabled == false)
                {
                    if (GetAsyncKeyState(Keys.F6)< 0)
                    {
                        StartButton.Enabled = false;
                        enabled = true;
                        StopButton.Enabled = true;
                    }    
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) // Checks if the window is minimized
            {           
                if (f2.minimizeToTray == true)
                {
                    this.ShowInTaskbar = false;
                    MinimizedNotifyIcon.Visible = true;
                    MinimizedNotifyIcon.Icon = this.Icon;
                    MinimizedNotifyIcon.BalloonTipTitle = "Auto Clicker has been minimized";
                    MinimizedNotifyIcon.BalloonTipText = "Click the icon to open the application again";
                    MinimizedNotifyIcon.ShowBalloonTip(1000); // Shows the notify icon to the taskbar for 1 second
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
            f2.Show(); // Shows Options window
        }
    }
}
