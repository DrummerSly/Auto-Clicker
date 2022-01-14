
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HoursTextbox = new System.Windows.Forms.TextBox();
            this.MinutesTextbox = new System.Windows.Forms.TextBox();
            this.SecondsTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MilisecondsTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClickTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.MouseButtonDropDownList = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.MinimizedNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MNIContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.ACBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.MNIContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.HoursTextbox);
            groupBox1.Controls.Add(this.MinutesTextbox);
            groupBox1.Controls.Add(this.SecondsTextbox);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.MilisecondsTextbox);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(118, 133);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click Intervals";
            // 
            // HoursTextbox
            // 
            this.HoursTextbox.Location = new System.Drawing.Point(6, 25);
            this.HoursTextbox.MaxLength = 6;
            this.HoursTextbox.Name = "HoursTextbox";
            this.HoursTextbox.Size = new System.Drawing.Size(43, 20);
            this.HoursTextbox.TabIndex = 5;
            this.HoursTextbox.Text = "0";
            this.HoursTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HoursTextbox.TextChanged += new System.EventHandler(this.Hours_TextChanged);
            // 
            // MinutesTextbox
            // 
            this.MinutesTextbox.Location = new System.Drawing.Point(6, 51);
            this.MinutesTextbox.MaxLength = 6;
            this.MinutesTextbox.Name = "MinutesTextbox";
            this.MinutesTextbox.Size = new System.Drawing.Size(43, 20);
            this.MinutesTextbox.TabIndex = 7;
            this.MinutesTextbox.Text = "0";
            this.MinutesTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinutesTextbox.TextChanged += new System.EventHandler(this.Minutes_TextChanged);
            // 
            // SecondsTextbox
            // 
            this.SecondsTextbox.Location = new System.Drawing.Point(6, 77);
            this.SecondsTextbox.MaxLength = 6;
            this.SecondsTextbox.Name = "SecondsTextbox";
            this.SecondsTextbox.Size = new System.Drawing.Size(43, 20);
            this.SecondsTextbox.TabIndex = 8;
            this.SecondsTextbox.Text = "0";
            this.SecondsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondsTextbox.TextChanged += new System.EventHandler(this.Seconds_TextChanged);
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
            // MilisecondsTextbox
            // 
            this.MilisecondsTextbox.Location = new System.Drawing.Point(6, 103);
            this.MilisecondsTextbox.MaxLength = 6;
            this.MilisecondsTextbox.Name = "MilisecondsTextbox";
            this.MilisecondsTextbox.Size = new System.Drawing.Size(43, 20);
            this.MilisecondsTextbox.TabIndex = 9;
            this.MilisecondsTextbox.Text = "100";
            this.MilisecondsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MilisecondsTextbox.TextChanged += new System.EventHandler(this.Miliseconds_TextChanged);
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
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(this.ClickTypeDropDownList);
            groupBox2.Controls.Add(this.MouseButtonDropDownList);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(144, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(150, 82);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click Options";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Location = new System.Drawing.Point(4, 26);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 13);
            label7.TabIndex = 13;
            label7.Text = "Mouse Button:";
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Location = new System.Drawing.Point(4, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 13);
            label8.TabIndex = 14;
            label8.Text = "Click Type:";
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(11, 146);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(283, 50);
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
            this.StopButton.Size = new System.Drawing.Size(283, 53);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop (F7)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MinimizedNotifyIcon
            // 
            this.MinimizedNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MinimizedNotifyIcon.ContextMenuStrip = this.MNIContextMenuStrip;
            this.MinimizedNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizedNotifyIcon.Icon")));
            this.MinimizedNotifyIcon.Text = "Auto Clicker";
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
            this.OptionsButton.Location = new System.Drawing.Point(144, 94);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(150, 46);
            this.OptionsButton.TabIndex = 23;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // ACBackgroundWorker
            // 
            this.ACBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ACBackgroundWorker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 265);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
        private System.Windows.Forms.NotifyIcon MinimizedNotifyIcon;
        private System.Windows.Forms.ComboBox MouseButtonDropDownList;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.TextBox HoursTextbox;
        private System.Windows.Forms.TextBox MinutesTextbox;
        private System.Windows.Forms.TextBox SecondsTextbox;
        private System.Windows.Forms.TextBox MilisecondsTextbox;
        private System.Windows.Forms.ContextMenuStrip MNIContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker ACBackgroundWorker;
        public System.Windows.Forms.ComboBox ClickTypeDropDownList;
    }
}

