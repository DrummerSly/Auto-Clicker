using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace autoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        private const int MIDDLEUP = 0x0040;
        private const int MIDDLEDOWN = 0x0020;
        private const int RIGHTUP = 0x0010;
        private const int RIGHTDOWN = 0x0008;

        public int milisecondsIntervals = 100;
        public int secondsIntervals = 000;
        public int minutesIntervals = 0;
        public int hoursIntervals = 0;
        public int parsedValue;

        public bool enabled = false;
        
        public string clickType = "single";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            EnableACHotkey.RunWorkerAsync();

            AC.Start();
        }

        private void AutoClick()
        {
            while (true)
            {
                if (enabled == true)
                {
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);

                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(int.Parse(hoursIntervals.ToString().PadRight(7, '0')));
                    Thread.Sleep(int.Parse(minutesIntervals.ToString().PadRight(5, '0')));
                    Thread.Sleep(int.Parse(secondsIntervals.ToString().PadRight(4, '0')));
                    Thread.Sleep(milisecondsIntervals);
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
            if (!int.TryParse(Miliseconds.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a number");
                return;
            } else
            {
                milisecondsIntervals = int.Parse(Miliseconds.Text);
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
                if (int.Parse(Minutes.Text) != 0)
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
                    if (GetAsyncKeyState(Keys.F7)< 0)
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
            if (this.WindowState == FormWindowState.Minimized)
            {           
                this.ShowInTaskbar = false;
                MinimizedNotifyIcon.Icon = this.Icon;
                MinimizedNotifyIcon.BalloonTipTitle = "Auto Clicker has been minimized";
                MinimizedNotifyIcon.BalloonTipText = "Click the icon to open the application again";
                MinimizedNotifyIcon.ShowBalloonTip(1000);
            }
        }

        private void MinimizedNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}