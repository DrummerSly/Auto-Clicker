﻿using System.Runtime.InteropServices;
using AutoClicker.Properties;
using System.Windows.Forms;
using System.Threading;
using System;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(Keys key);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwEI);

        int hInterval;
        int mInterval;
        int sInterval;
        int miInterval;

        int hInput;
        int mInput;
        int sInput;
        int miInput;

        bool enabled = false;

        string mouseButton;
        string clickType;

        private void AutoClick()
        {
            while (true)
            {
                if (enabled == true)
                {
                    if (mouseButton == "Left")
                    {
                        if (clickType == "Single")
                        {
                            mouse_event(0x04, 0, 0, 0, 0);
                            mouse_event(0x02, 0, 0, 0, 0);
                        }
                        else
                        {
                            mouse_event(0x04, 0, 0, 0, 0);
                            mouse_event(0x02, 0, 0, 0, 0);
                            mouse_event(0x04, 0, 0, 0, 0);
                            mouse_event(0x02, 0, 0, 0, 0);
                        }
                    } else if (mouseButton == "Middle")
                    {
                        if (clickType == "Single")
                        {
                            mouse_event(0x40, 0, 0, 0, 0);
                            mouse_event(0x20, 0, 0, 0, 0);
                        }
                        else
                        {
                            mouse_event(0x40, 0, 0, 0, 0);
                            mouse_event(0x20, 0, 0, 0, 0);
                            mouse_event(0x40, 0, 0, 0, 0);
                            mouse_event(0x20, 0, 0, 0, 0);
                        }
                    } else if (mouseButton == "Right")
                    {
                        if (clickType == "Single")
                        {
                            mouse_event(0x10, 0, 0, 0, 0);
                            mouse_event(0x08, 0, 0, 0, 0);
                        }
                        else
                        {
                            mouse_event(0x10, 0, 0, 0, 0);
                            mouse_event(0x08, 0, 0, 0, 0);
                            mouse_event(0x10, 0, 0, 0, 0);
                            mouse_event(0x08, 0, 0, 0, 0);
                        }
                    }
                    Thread.Sleep(hInterval + mInterval + sInterval + miInterval);
                }
                Thread.Sleep(1);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread AC = new Thread(AutoClick);
            AC.IsBackground = true;

            BackgroundWorker.RunWorkerAsync();

            if (Settings.Default.KeepWindowOnTop == true)
            {
                this.TopMost = true;
            }

            MBDropDownList.SelectedItem = Settings.Default.EDOMouseButton;
            CTDropDownList.SelectedItem = Settings.Default.EDOClickType;

            if (Settings.Default.EnableDefaultIntervals == true)
            {
                HTextBox.Text = Settings.Default.EDIHoursInterval.ToString();
                MTextBox.Text = Settings.Default.EDIMinutesInterval.ToString();
                STextBox.Text = Settings.Default.EDISecondsInterval.ToString();
                MiTextBox.Text = Settings.Default.EDIMilisecondsInterval.ToString();
            }

            AC.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.KeepWindowOnTop == false)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }

            if (Settings.Default.DisplayStatus == true)
            {
                this.Text = "Auto Clicker: Running";
            }

            StartButton.Enabled = false;
            StopButton.Enabled = true;
            enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            enabled = false;
        }

        private void HTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HTextBox.Text != "0")
            {
                if (int.TryParse(HTextBox.Text, out hInput))
                {
                    hInterval = 3600000 * hInput;
                }
                else
                {
                    HTextBox.Text = "";
                }
            }
        }

        private void MTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MTextBox.Text != "0")
            {
                if (int.TryParse(MTextBox.Text, out mInput))
                {
                    mInterval = 60000 * mInput;
                }
                else
                {
                    MTextBox.Text = "";
                }
            }
        }

        private void STextBox_TextChanged(object sender, EventArgs e)
        {
            if (STextBox.Text != "0")
            {
                if (int.TryParse(STextBox.Text, out sInput))
                {
                    sInterval = 1000 * sInput;
                }
                else
                {
                    STextBox.Text = "";
                }
            }
        }

        private void MiTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MiTextBox.Text != "0")
            {
                if (int.TryParse(MiTextBox.Text, out miInput))
                {
                    miInterval = 1 * miInput;
                }
                else
                {
                    MiTextBox.Text = "";
                }
            }
        }

        private void MBDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouseButton = MBDropDownList.SelectedItem.ToString();
        }

        private void CTDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickType = CTDropDownList.SelectedItem.ToString();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (enabled == false)
                {
                    if (GetAsyncKeyState(Keys.RMenu) < 0)
                    {
                        if (Settings.Default.DisplayStatus == true)
                        {
                            this.Text = "Auto Clicker: Running";
                        }

                        StartButton.Enabled = false;
                        StopButton.Enabled = true;
                        enabled = true;
                    }
                }
                else if (enabled == true)
                {
                    if (GetAsyncKeyState(Keys.RControlKey) < 0)
                    {
                        if (Settings.Default.DisplayStatus == true)
                        {
                            this.Text = "Auto Clicker: Stopped";
                        }

                        StartButton.Enabled = true;
                        StopButton.Enabled = false;
                        enabled = false;
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (Settings.Default.MinimizeToTray == true)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    NotifyIcon.Visible = true;
                    this.Hide();
                }
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            NotifyIcon.Visible = false;
        }
    }
}