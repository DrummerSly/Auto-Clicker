
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Decoration1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // Decoration1
            // 
            this.Decoration1.Enabled = false;
            this.Decoration1.Location = new System.Drawing.Point(6, 14);
            this.Decoration1.Name = "Decoration1";
            this.Decoration1.Size = new System.Drawing.Size(123, 132);
            this.Decoration1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
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
            this.StartButton.Location = new System.Drawing.Point(145, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(202, 43);
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
            this.StopButton.Location = new System.Drawing.Point(145, 79);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(202, 43);
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
            this.MinimizedNotifyIcon.Text = "MinimizedNotifyIcon";
            this.MinimizedNotifyIcon.Visible = true;
            this.MinimizedNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizedNotifyIcon_MouseClick);
            // 
            // UnavaibleCharacterNotifyIcon
            // 
            this.UnavaibleCharacterNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.UnavaibleCharacterNotifyIcon.Text = "UnavaibleCharacterNotifyIcon";
            this.UnavaibleCharacterNotifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 159);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Miliseconds);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decoration1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private System.Windows.Forms.Button Decoration1;
        private System.Windows.Forms.NotifyIcon UnavaibleCharacterNotifyIcon;
    }
}

