namespace autoClicker
{
    partial class Form1
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
            System.Windows.Forms.Button Decoration;
            System.Windows.Forms.Button Decoration1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.Miliseconds = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.EnableACHotkey = new System.ComponentModel.BackgroundWorker();
            this.MinimizedNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.UnavaibleCharacterNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MouseButtonDropDownList = new System.Windows.Forms.ComboBox();
            this.ClickTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OptionsButton = new System.Windows.Forms.Button();
            Decoration = new System.Windows.Forms.Button();
            Decoration1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decoration
            // 
            Decoration.Enabled = false;
            Decoration.Location = new System.Drawing.Point(6, 14);
            Decoration.Name = "Decoration";
            Decoration.Size = new System.Drawing.Size(123, 132);
            Decoration.TabIndex = 0;
            Decoration.TabStop = false;
            // 
            // Decoration1
            // 
            Decoration1.Enabled = false;
            Decoration1.Location = new System.Drawing.Point(149, 14);
            Decoration1.Name = "Decoration1";
            Decoration1.Size = new System.Drawing.Size(154, 85);
            Decoration1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "miliseconds";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(15, 39);
            this.Hours.MaxLength = 6;
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(43, 20);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "0";
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Hours.TextChanged += new System.EventHandler(this.Hours_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(12, 157);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(137, 50);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "START (F6)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(15, 65);
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
            this.Seconds.Location = new System.Drawing.Point(15, 91);
            this.Seconds.MaxLength = 6;
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(43, 20);
            this.Seconds.TabIndex = 8;
            this.Seconds.Text = "0";
            this.Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Seconds.TextChanged += new System.EventHandler(this.Seconds_TextChanged);
            // 
            // Miliseconds
            // 
            this.Miliseconds.Location = new System.Drawing.Point(15, 117);
            this.Miliseconds.MaxLength = 6;
            this.Miliseconds.Name = "Miliseconds";
            this.Miliseconds.Size = new System.Drawing.Size(43, 20);
            this.Miliseconds.TabIndex = 9;
            this.Miliseconds.Text = "100";
            this.Miliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Miliseconds.TextChanged += new System.EventHandler(this.Miliseconds_TextChanged);
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(12, 218);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(285, 53);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "STOP (F7)";
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
            this.MinimizedNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizedNotifyIcon.Icon")));
            this.MinimizedNotifyIcon.Text = "Auto Clicker";
            this.MinimizedNotifyIcon.Visible = true;
            this.MinimizedNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizedNotifyIcon_MouseClick);
            // 
            // UnavaibleCharacterNotifyIcon
            // 
            this.UnavaibleCharacterNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.UnavaibleCharacterNotifyIcon.Text = "UnavaibleCharacterNotifyIcon";
            this.UnavaibleCharacterNotifyIcon.Visible = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Click Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mouse Button:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Click Type:";
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
            this.MouseButtonDropDownList.Location = new System.Drawing.Point(239, 36);
            this.MouseButtonDropDownList.MaxDropDownItems = 3;
            this.MouseButtonDropDownList.Name = "MouseButtonDropDownList";
            this.MouseButtonDropDownList.Size = new System.Drawing.Size(58, 21);
            this.MouseButtonDropDownList.TabIndex = 17;
            this.MouseButtonDropDownList.SelectedIndexChanged += new System.EventHandler(this.MouseButtonDropDownList_SelectedIndexChanged);
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
            this.ClickTypeDropDownList.Location = new System.Drawing.Point(239, 65);
            this.ClickTypeDropDownList.MaxDropDownItems = 3;
            this.ClickTypeDropDownList.Name = "ClickTypeDropDownList";
            this.ClickTypeDropDownList.Size = new System.Drawing.Size(58, 21);
            this.ClickTypeDropDownList.TabIndex = 18;
            this.ClickTypeDropDownList.SelectedIndexChanged += new System.EventHandler(this.ClickTypeDropDownList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Auto Clicker by Drumly_x";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsButton.Location = new System.Drawing.Point(160, 157);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(137, 50);
            this.OptionsButton.TabIndex = 20;
            this.OptionsButton.Text = "OPTIONS";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 283);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClickTypeDropDownList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MouseButtonDropDownList);
            this.Controls.Add(this.Miliseconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(Decoration);
            this.Controls.Add(Decoration1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.TextBox Miliseconds;
        private System.Windows.Forms.Button StopButton;
        private System.ComponentModel.BackgroundWorker EnableACHotkey;
        private System.Windows.Forms.NotifyIcon MinimizedNotifyIcon;
        private System.Windows.Forms.NotifyIcon UnavaibleCharacterNotifyIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MouseButtonDropDownList;
        private System.Windows.Forms.ComboBox ClickTypeDropDownList;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button OptionsButton;
    }
}

