
namespace autoClicker2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Hours = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Miliseconds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClickTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.MouseButtonDropDownList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.EnableACHotkey = new System.ComponentModel.BackgroundWorker();
            this.MinimizedNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MNIContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.MNIContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.Hours);
            groupBox1.Controls.Add(this.Minutes);
            groupBox1.Controls.Add(this.Seconds);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.Miliseconds);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(118, 133);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click Interval";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(6, 25);
            this.Hours.MaxLength = 6;
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(43, 20);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "0";
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Hours.TextChanged += new System.EventHandler(this.Hours_TextChanged);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(6, 51);
            this.Minutes.MaxLength = 6;
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(43, 20);
            this.Minutes.TabIndex = 7;
            this.Minutes.Text = "0";
            this.Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Minutes.TextChanged += new System.EventHandler(this.Minutes_TextChanged);
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(6, 77);
            this.Seconds.MaxLength = 6;
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(43, 20);
            this.Seconds.TabIndex = 8;
            this.Seconds.Text = "0";
            this.Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Seconds.TextChanged += new System.EventHandler(this.Seconds_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "minutes";
            // 
            // Miliseconds
            // 
            this.Miliseconds.Location = new System.Drawing.Point(6, 103);
            this.Miliseconds.MaxLength = 6;
            this.Miliseconds.Name = "Miliseconds";
            this.Miliseconds.Size = new System.Drawing.Size(43, 20);
            this.Miliseconds.TabIndex = 9;
            this.Miliseconds.Text = "100";
            this.Miliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Miliseconds.TextChanged += new System.EventHandler(this.Miliseconds_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "miliseconds";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.label7);
            groupBox2.Controls.Add(this.ClickTypeDropDownList);
            groupBox2.Controls.Add(this.MouseButtonDropDownList);
            groupBox2.Controls.Add(this.label8);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(135, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(150, 82);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mouse Button:";
            // 
            // ClickTypeDropDownList
            // 
            this.ClickTypeDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickTypeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClickTypeDropDownList.FormattingEnabled = true;
            this.ClickTypeDropDownList.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.ClickTypeDropDownList.Location = new System.Drawing.Point(84, 52);
            this.ClickTypeDropDownList.MaxDropDownItems = 3;
            this.ClickTypeDropDownList.Name = "ClickTypeDropDownList";
            this.ClickTypeDropDownList.Size = new System.Drawing.Size(58, 21);
            this.ClickTypeDropDownList.TabIndex = 18;
            this.ClickTypeDropDownList.SelectedIndexChanged += new System.EventHandler(this.ClickTypeDropDownList_SelectedIndexChanged);
            // 
            // MouseButtonDropDownList
            // 
            this.MouseButtonDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseButtonDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MouseButtonDropDownList.FormattingEnabled = true;
            this.MouseButtonDropDownList.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.MouseButtonDropDownList.Location = new System.Drawing.Point(84, 23);
            this.MouseButtonDropDownList.MaxDropDownItems = 3;
            this.MouseButtonDropDownList.Name = "MouseButtonDropDownList";
            this.MouseButtonDropDownList.Size = new System.Drawing.Size(58, 21);
            this.MouseButtonDropDownList.TabIndex = 17;
            this.MouseButtonDropDownList.SelectedIndexChanged += new System.EventHandler(this.MouseButtonDropDownList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(4, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Click Type:";
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(11, 146);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(274, 50);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start (F6)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(11, 202);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(274, 53);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop (F7)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EnableACHotkey
            // 
            this.EnableACHotkey.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MinimizedNotifyIcon
            // 
            this.MinimizedNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MinimizedNotifyIcon.ContextMenuStrip = this.MNIContextMenuStrip;
            this.MinimizedNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizedNotifyIcon.Icon")));
            this.MinimizedNotifyIcon.Text = "Auto Clicker";
            this.MinimizedNotifyIcon.Visible = true;
            // 
            // MNIContextMenuStrip
            // 
            this.MNIContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.MNIContextMenuStrip.Name = "MNIContextMenuStrip";
            this.MNIContextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsButton.Location = new System.Drawing.Point(135, 94);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(150, 46);
            this.OptionsButton.TabIndex = 23;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 265);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.MNIContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.ComponentModel.BackgroundWorker EnableACHotkey;
        private System.Windows.Forms.NotifyIcon MinimizedNotifyIcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MouseButtonDropDownList;
        public System.Windows.Forms.ComboBox ClickTypeDropDownList;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.TextBox Miliseconds;
        private System.Windows.Forms.ContextMenuStrip MNIContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

