namespace autoClicker
{
    partial class OptionsForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.StartMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimizetoTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableDefaultIntervalsCheckBox = new System.Windows.Forms.CheckBox();
            this.EDIMinutes = new System.Windows.Forms.TextBox();
            this.EDISeconds = new System.Windows.Forms.TextBox();
            this.EDIHours = new System.Windows.Forms.TextBox();
            this.EDIHoursLabel = new System.Windows.Forms.Label();
            this.EDIMinutesLabel = new System.Windows.Forms.Label();
            this.EDISecondsLabel = new System.Windows.Forms.Label();
            this.EDIMilisecondsLabel = new System.Windows.Forms.Label();
            this.EDIMiliseconds = new System.Windows.Forms.TextBox();
            this.EnableDefaultOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.EDOMouseButtonDropDownList = new System.Windows.Forms.ComboBox();
            this.EDOMouseButtonLabel = new System.Windows.Forms.Label();
            this.EDOClickTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.EDOClickTypeLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.RestoreDefaultsButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.StartMinimizedCheckBox);
            groupBox1.Controls.Add(this.MinimizetoTrayCheckBox);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(307, 47);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application";
            // 
            // StartMinimizedCheckBox
            // 
            this.StartMinimizedCheckBox.AutoSize = true;
            this.StartMinimizedCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.StartMinimizedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartMinimizedCheckBox.Location = new System.Drawing.Point(6, 19);
            this.StartMinimizedCheckBox.Name = "StartMinimizedCheckBox";
            this.StartMinimizedCheckBox.Size = new System.Drawing.Size(97, 17);
            this.StartMinimizedCheckBox.TabIndex = 42;
            this.StartMinimizedCheckBox.Text = "Start Minimized";
            this.StartMinimizedCheckBox.UseVisualStyleBackColor = false;
            this.StartMinimizedCheckBox.CheckedChanged += new System.EventHandler(this.StartMinimizedCheckBox_CheckedChanged);
            // 
            // MinimizetoTrayCheckBox
            // 
            this.MinimizetoTrayCheckBox.AutoSize = true;
            this.MinimizetoTrayCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizetoTrayCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizetoTrayCheckBox.Location = new System.Drawing.Point(109, 19);
            this.MinimizetoTrayCheckBox.Name = "MinimizetoTrayCheckBox";
            this.MinimizetoTrayCheckBox.Size = new System.Drawing.Size(102, 17);
            this.MinimizetoTrayCheckBox.TabIndex = 24;
            this.MinimizetoTrayCheckBox.Text = "Minimize to Tray";
            this.MinimizetoTrayCheckBox.UseVisualStyleBackColor = false;
            this.MinimizetoTrayCheckBox.CheckedChanged += new System.EventHandler(this.MinimizetoTrayCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.EnableDefaultIntervalsCheckBox);
            groupBox2.Controls.Add(this.EDIMinutes);
            groupBox2.Controls.Add(this.EDISeconds);
            groupBox2.Controls.Add(this.EDIHours);
            groupBox2.Controls.Add(this.EDIHoursLabel);
            groupBox2.Controls.Add(this.EDIMinutesLabel);
            groupBox2.Controls.Add(this.EDISecondsLabel);
            groupBox2.Controls.Add(this.EDIMilisecondsLabel);
            groupBox2.Controls.Add(this.EDIMiliseconds);
            groupBox2.Location = new System.Drawing.Point(12, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(146, 147);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click Intervals";
            // 
            // EnableDefaultIntervalsCheckBox
            // 
            this.EnableDefaultIntervalsCheckBox.AutoSize = true;
            this.EnableDefaultIntervalsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableDefaultIntervalsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableDefaultIntervalsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.EnableDefaultIntervalsCheckBox.Name = "EnableDefaultIntervalsCheckBox";
            this.EnableDefaultIntervalsCheckBox.Size = new System.Drawing.Size(139, 17);
            this.EnableDefaultIntervalsCheckBox.TabIndex = 27;
            this.EnableDefaultIntervalsCheckBox.Text = "Enable Default Intervals";
            this.EnableDefaultIntervalsCheckBox.UseVisualStyleBackColor = false;
            this.EnableDefaultIntervalsCheckBox.CheckedChanged += new System.EventHandler(this.EnableDefaultIntervalsCheckBox_CheckedChanged);
            // 
            // EDIMinutes
            // 
            this.EDIMinutes.Enabled = false;
            this.EDIMinutes.Location = new System.Drawing.Point(6, 68);
            this.EDIMinutes.MaxLength = 6;
            this.EDIMinutes.Name = "EDIMinutes";
            this.EDIMinutes.Size = new System.Drawing.Size(43, 20);
            this.EDIMinutes.TabIndex = 33;
            this.EDIMinutes.Text = "0";
            this.EDIMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDIMinutes.TextChanged += new System.EventHandler(this.EDIMinutes_TextChanged);
            // 
            // EDISeconds
            // 
            this.EDISeconds.Enabled = false;
            this.EDISeconds.Location = new System.Drawing.Point(6, 94);
            this.EDISeconds.MaxLength = 6;
            this.EDISeconds.Name = "EDISeconds";
            this.EDISeconds.Size = new System.Drawing.Size(43, 20);
            this.EDISeconds.TabIndex = 34;
            this.EDISeconds.Text = "0";
            this.EDISeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDISeconds.TextChanged += new System.EventHandler(this.EDISeconds_TextChanged);
            // 
            // EDIHours
            // 
            this.EDIHours.Enabled = false;
            this.EDIHours.Location = new System.Drawing.Point(6, 42);
            this.EDIHours.MaxLength = 6;
            this.EDIHours.Name = "EDIHours";
            this.EDIHours.Size = new System.Drawing.Size(43, 20);
            this.EDIHours.TabIndex = 32;
            this.EDIHours.Text = "0";
            this.EDIHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDIHours.TextChanged += new System.EventHandler(this.EDIHours_TextChanged);
            // 
            // EDIHoursLabel
            // 
            this.EDIHoursLabel.AutoSize = true;
            this.EDIHoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDIHoursLabel.Enabled = false;
            this.EDIHoursLabel.Location = new System.Drawing.Point(53, 45);
            this.EDIHoursLabel.Name = "EDIHoursLabel";
            this.EDIHoursLabel.Size = new System.Drawing.Size(33, 13);
            this.EDIHoursLabel.TabIndex = 28;
            this.EDIHoursLabel.Text = "hours";
            // 
            // EDIMinutesLabel
            // 
            this.EDIMinutesLabel.AutoSize = true;
            this.EDIMinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDIMinutesLabel.Enabled = false;
            this.EDIMinutesLabel.Location = new System.Drawing.Point(53, 71);
            this.EDIMinutesLabel.Name = "EDIMinutesLabel";
            this.EDIMinutesLabel.Size = new System.Drawing.Size(43, 13);
            this.EDIMinutesLabel.TabIndex = 29;
            this.EDIMinutesLabel.Text = "minutes";
            // 
            // EDISecondsLabel
            // 
            this.EDISecondsLabel.AutoSize = true;
            this.EDISecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDISecondsLabel.Enabled = false;
            this.EDISecondsLabel.Location = new System.Drawing.Point(53, 97);
            this.EDISecondsLabel.Name = "EDISecondsLabel";
            this.EDISecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.EDISecondsLabel.TabIndex = 30;
            this.EDISecondsLabel.Text = "seconds";
            // 
            // EDIMilisecondsLabel
            // 
            this.EDIMilisecondsLabel.AutoSize = true;
            this.EDIMilisecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDIMilisecondsLabel.Enabled = false;
            this.EDIMilisecondsLabel.Location = new System.Drawing.Point(53, 123);
            this.EDIMilisecondsLabel.Name = "EDIMilisecondsLabel";
            this.EDIMilisecondsLabel.Size = new System.Drawing.Size(61, 13);
            this.EDIMilisecondsLabel.TabIndex = 31;
            this.EDIMilisecondsLabel.Text = "miliseconds";
            // 
            // EDIMiliseconds
            // 
            this.EDIMiliseconds.Enabled = false;
            this.EDIMiliseconds.Location = new System.Drawing.Point(6, 120);
            this.EDIMiliseconds.MaxLength = 6;
            this.EDIMiliseconds.Name = "EDIMiliseconds";
            this.EDIMiliseconds.Size = new System.Drawing.Size(43, 20);
            this.EDIMiliseconds.TabIndex = 35;
            this.EDIMiliseconds.Text = "100";
            this.EDIMiliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDIMiliseconds.TextChanged += new System.EventHandler(this.EDIMiliseconds_TextChanged);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.EnableDefaultOptionsCheckBox);
            groupBox3.Controls.Add(this.EDOMouseButtonDropDownList);
            groupBox3.Controls.Add(this.EDOMouseButtonLabel);
            groupBox3.Controls.Add(this.EDOClickTypeDropDownList);
            groupBox3.Controls.Add(this.EDOClickTypeLabel);
            groupBox3.Location = new System.Drawing.Point(173, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(146, 147);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Click Options";
            // 
            // EnableDefaultOptionsCheckBox
            // 
            this.EnableDefaultOptionsCheckBox.AutoSize = true;
            this.EnableDefaultOptionsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableDefaultOptionsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableDefaultOptionsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.EnableDefaultOptionsCheckBox.Name = "EnableDefaultOptionsCheckBox";
            this.EnableDefaultOptionsCheckBox.Size = new System.Drawing.Size(135, 17);
            this.EnableDefaultOptionsCheckBox.TabIndex = 37;
            this.EnableDefaultOptionsCheckBox.Text = "Enable Default Options";
            this.EnableDefaultOptionsCheckBox.UseVisualStyleBackColor = false;
            this.EnableDefaultOptionsCheckBox.CheckedChanged += new System.EventHandler(this.EnableDefaultOptionsCheckBox_CheckedChanged);
            // 
            // EDOMouseButtonDropDownList
            // 
            this.EDOMouseButtonDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDOMouseButtonDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDOMouseButtonDropDownList.Enabled = false;
            this.EDOMouseButtonDropDownList.FormattingEnabled = true;
            this.EDOMouseButtonDropDownList.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.EDOMouseButtonDropDownList.Location = new System.Drawing.Point(83, 42);
            this.EDOMouseButtonDropDownList.MaxDropDownItems = 3;
            this.EDOMouseButtonDropDownList.Name = "EDOMouseButtonDropDownList";
            this.EDOMouseButtonDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOMouseButtonDropDownList.TabIndex = 38;
            this.EDOMouseButtonDropDownList.SelectedIndexChanged += new System.EventHandler(this.EDOMouseButtonDropDownList_SelectedIndexChanged);
            // 
            // EDOMouseButtonLabel
            // 
            this.EDOMouseButtonLabel.AutoSize = true;
            this.EDOMouseButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDOMouseButtonLabel.Enabled = false;
            this.EDOMouseButtonLabel.Location = new System.Drawing.Point(3, 45);
            this.EDOMouseButtonLabel.Name = "EDOMouseButtonLabel";
            this.EDOMouseButtonLabel.Size = new System.Drawing.Size(76, 13);
            this.EDOMouseButtonLabel.TabIndex = 39;
            this.EDOMouseButtonLabel.Text = "Mouse Button:";
            // 
            // EDOClickTypeDropDownList
            // 
            this.EDOClickTypeDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDOClickTypeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDOClickTypeDropDownList.Enabled = false;
            this.EDOClickTypeDropDownList.FormattingEnabled = true;
            this.EDOClickTypeDropDownList.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.EDOClickTypeDropDownList.Location = new System.Drawing.Point(83, 71);
            this.EDOClickTypeDropDownList.MaxDropDownItems = 3;
            this.EDOClickTypeDropDownList.Name = "EDOClickTypeDropDownList";
            this.EDOClickTypeDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOClickTypeDropDownList.TabIndex = 41;
            this.EDOClickTypeDropDownList.SelectedIndexChanged += new System.EventHandler(this.EDOClickTypeDropDownList_SelectedIndexChanged);
            // 
            // EDOClickTypeLabel
            // 
            this.EDOClickTypeLabel.AutoSize = true;
            this.EDOClickTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDOClickTypeLabel.Enabled = false;
            this.EDOClickTypeLabel.Location = new System.Drawing.Point(3, 75);
            this.EDOClickTypeLabel.Name = "EDOClickTypeLabel";
            this.EDOClickTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.EDOClickTypeLabel.TabIndex = 40;
            this.EDOClickTypeLabel.Text = "Click Type:";
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Location = new System.Drawing.Point(247, 229);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButton.Location = new System.Drawing.Point(164, 229);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 26;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // RestoreDefaultsButton
            // 
            this.RestoreDefaultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDefaultsButton.Location = new System.Drawing.Point(12, 229);
            this.RestoreDefaultsButton.Name = "RestoreDefaultsButton";
            this.RestoreDefaultsButton.Size = new System.Drawing.Size(94, 23);
            this.RestoreDefaultsButton.TabIndex = 46;
            this.RestoreDefaultsButton.Text = "Restore Defaults";
            this.RestoreDefaultsButton.UseVisualStyleBackColor = true;
            this.RestoreDefaultsButton.Click += new System.EventHandler(this.RestoreDefaultsButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.RestoreDefaultsButton);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox MinimizetoTrayCheckBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label EDIMinutesLabel;
        private System.Windows.Forms.TextBox EDISeconds;
        private System.Windows.Forms.TextBox EDIHours;
        public System.Windows.Forms.CheckBox EnableDefaultIntervalsCheckBox;
        private System.Windows.Forms.TextBox EDIMinutes;
        private System.Windows.Forms.Label EDIHoursLabel;
        private System.Windows.Forms.TextBox EDIMiliseconds;
        private System.Windows.Forms.Label EDIMilisecondsLabel;
        private System.Windows.Forms.Label EDISecondsLabel;
        public System.Windows.Forms.CheckBox EnableDefaultOptionsCheckBox;
        private System.Windows.Forms.Label EDOMouseButtonLabel;
        public System.Windows.Forms.ComboBox EDOMouseButtonDropDownList;
        private System.Windows.Forms.Label EDOClickTypeLabel;
        public System.Windows.Forms.ComboBox EDOClickTypeDropDownList;
        public System.Windows.Forms.CheckBox StartMinimizedCheckBox;
        private System.Windows.Forms.Button RestoreDefaultsButton;
    }
}
