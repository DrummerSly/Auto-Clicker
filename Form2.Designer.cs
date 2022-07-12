
namespace AutoClicker
{
    partial class Form2
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
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.KPoTCheckBox = new System.Windows.Forms.CheckBox();
            this.DSCheckBox = new System.Windows.Forms.CheckBox();
            this.MtTCheckBox = new System.Windows.Forms.CheckBox();
            this.EDOCheckBox = new System.Windows.Forms.CheckBox();
            this.EDOMBDropDownList = new System.Windows.Forms.ComboBox();
            this.EDOMBLabel = new System.Windows.Forms.Label();
            this.EDOCTDropDownList = new System.Windows.Forms.ComboBox();
            this.EDOCTLabel = new System.Windows.Forms.Label();
            this.EDICheckBox = new System.Windows.Forms.CheckBox();
            this.EDIMinutes = new System.Windows.Forms.TextBox();
            this.EDISeconds = new System.Windows.Forms.TextBox();
            this.EDIHours = new System.Windows.Forms.TextBox();
            this.EDIHoursLabel = new System.Windows.Forms.Label();
            this.EDIMinutesLabel = new System.Windows.Forms.Label();
            this.EDISecondsLabel = new System.Windows.Forms.Label();
            this.EDIMilisecondsLabel = new System.Windows.Forms.Label();
            this.EDIMiliseconds = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.KPoTCheckBox);
            groupBox1.Controls.Add(this.DSCheckBox);
            groupBox1.Controls.Add(this.MtTCheckBox);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(290, 65);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application";
            // 
            // KPoTCheckBox
            // 
            this.KPoTCheckBox.AutoSize = true;
            this.KPoTCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.KPoTCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KPoTCheckBox.Location = new System.Drawing.Point(114, 19);
            this.KPoTCheckBox.Name = "KPoTCheckBox";
            this.KPoTCheckBox.Size = new System.Drawing.Size(130, 17);
            this.KPoTCheckBox.TabIndex = 44;
            this.KPoTCheckBox.TabStop = false;
            this.KPoTCheckBox.Text = "Keep Program on Top";
            this.KPoTCheckBox.UseVisualStyleBackColor = false;
            this.KPoTCheckBox.CheckedChanged += new System.EventHandler(this.KPoTCheckBox_CheckedChanged);
            // 
            // DSCheckBox
            // 
            this.DSCheckBox.AutoSize = true;
            this.DSCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DSCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DSCheckBox.Location = new System.Drawing.Point(6, 42);
            this.DSCheckBox.Name = "DSCheckBox";
            this.DSCheckBox.Size = new System.Drawing.Size(93, 17);
            this.DSCheckBox.TabIndex = 43;
            this.DSCheckBox.TabStop = false;
            this.DSCheckBox.Text = "Display Status";
            this.DSCheckBox.UseVisualStyleBackColor = false;
            this.DSCheckBox.CheckedChanged += new System.EventHandler(this.DSCheckBox_CheckedChanged);
            // 
            // MtTCheckBox
            // 
            this.MtTCheckBox.AutoSize = true;
            this.MtTCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MtTCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MtTCheckBox.Location = new System.Drawing.Point(6, 19);
            this.MtTCheckBox.Name = "MtTCheckBox";
            this.MtTCheckBox.Size = new System.Drawing.Size(102, 17);
            this.MtTCheckBox.TabIndex = 24;
            this.MtTCheckBox.TabStop = false;
            this.MtTCheckBox.Text = "Minimize to Tray";
            this.MtTCheckBox.UseVisualStyleBackColor = false;
            this.MtTCheckBox.CheckedChanged += new System.EventHandler(this.MtTCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.EDOCheckBox);
            groupBox3.Controls.Add(this.EDOMBDropDownList);
            groupBox3.Controls.Add(this.EDOMBLabel);
            groupBox3.Controls.Add(this.EDOCTDropDownList);
            groupBox3.Controls.Add(this.EDOCTLabel);
            groupBox3.Location = new System.Drawing.Point(156, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox3.Size = new System.Drawing.Size(146, 147);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "Click Options";
            // 
            // EDOCheckBox
            // 
            this.EDOCheckBox.AutoSize = true;
            this.EDOCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EDOCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDOCheckBox.Location = new System.Drawing.Point(6, 19);
            this.EDOCheckBox.Name = "EDOCheckBox";
            this.EDOCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDOCheckBox.Size = new System.Drawing.Size(135, 17);
            this.EDOCheckBox.TabIndex = 37;
            this.EDOCheckBox.TabStop = false;
            this.EDOCheckBox.Text = "Enable Default Options";
            this.EDOCheckBox.UseVisualStyleBackColor = false;
            this.EDOCheckBox.CheckedChanged += new System.EventHandler(this.EDOCheckBox_CheckedChanged);
            // 
            // EDOMBDropDownList
            // 
            this.EDOMBDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDOMBDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDOMBDropDownList.Enabled = false;
            this.EDOMBDropDownList.FormattingEnabled = true;
            this.EDOMBDropDownList.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.EDOMBDropDownList.Location = new System.Drawing.Point(82, 42);
            this.EDOMBDropDownList.MaxDropDownItems = 3;
            this.EDOMBDropDownList.Name = "EDOMBDropDownList";
            this.EDOMBDropDownList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDOMBDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOMBDropDownList.TabIndex = 38;
            this.EDOMBDropDownList.TabStop = false;
            this.EDOMBDropDownList.SelectedIndexChanged += new System.EventHandler(this.EDOMBDropDownList_SelectedIndexChanged);
            // 
            // EDOMBLabel
            // 
            this.EDOMBLabel.AutoSize = true;
            this.EDOMBLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDOMBLabel.Enabled = false;
            this.EDOMBLabel.Location = new System.Drawing.Point(3, 45);
            this.EDOMBLabel.Name = "EDOMBLabel";
            this.EDOMBLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDOMBLabel.Size = new System.Drawing.Size(76, 13);
            this.EDOMBLabel.TabIndex = 39;
            this.EDOMBLabel.Text = "Mouse Button:";
            // 
            // EDOCTDropDownList
            // 
            this.EDOCTDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDOCTDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDOCTDropDownList.Enabled = false;
            this.EDOCTDropDownList.FormattingEnabled = true;
            this.EDOCTDropDownList.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.EDOCTDropDownList.Location = new System.Drawing.Point(82, 69);
            this.EDOCTDropDownList.MaxDropDownItems = 3;
            this.EDOCTDropDownList.Name = "EDOCTDropDownList";
            this.EDOCTDropDownList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDOCTDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOCTDropDownList.TabIndex = 41;
            this.EDOCTDropDownList.TabStop = false;
            this.EDOCTDropDownList.SelectedIndexChanged += new System.EventHandler(this.EDOCTDropDownList_SelectedIndexChanged);
            // 
            // EDOCTLabel
            // 
            this.EDOCTLabel.AutoSize = true;
            this.EDOCTLabel.BackColor = System.Drawing.Color.Transparent;
            this.EDOCTLabel.Enabled = false;
            this.EDOCTLabel.Location = new System.Drawing.Point(4, 72);
            this.EDOCTLabel.Name = "EDOCTLabel";
            this.EDOCTLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EDOCTLabel.Size = new System.Drawing.Size(60, 13);
            this.EDOCTLabel.TabIndex = 40;
            this.EDOCTLabel.Text = "Click Type:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.EDICheckBox);
            groupBox2.Controls.Add(this.EDIMinutes);
            groupBox2.Controls.Add(this.EDISeconds);
            groupBox2.Controls.Add(this.EDIHours);
            groupBox2.Controls.Add(this.EDIHoursLabel);
            groupBox2.Controls.Add(this.EDIMinutesLabel);
            groupBox2.Controls.Add(this.EDISecondsLabel);
            groupBox2.Controls.Add(this.EDIMilisecondsLabel);
            groupBox2.Controls.Add(this.EDIMiliseconds);
            groupBox2.Location = new System.Drawing.Point(12, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(138, 147);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click Interval";
            // 
            // EDICheckBox
            // 
            this.EDICheckBox.AutoSize = true;
            this.EDICheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EDICheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDICheckBox.Location = new System.Drawing.Point(6, 19);
            this.EDICheckBox.Name = "EDICheckBox";
            this.EDICheckBox.Size = new System.Drawing.Size(134, 17);
            this.EDICheckBox.TabIndex = 27;
            this.EDICheckBox.TabStop = false;
            this.EDICheckBox.Text = "Enable Default Interval";
            this.EDICheckBox.UseVisualStyleBackColor = false;
            this.EDICheckBox.CheckedChanged += new System.EventHandler(this.EDICheckBox_CheckedChanged);
            // 
            // EDIMinutes
            // 
            this.EDIMinutes.Enabled = false;
            this.EDIMinutes.Location = new System.Drawing.Point(6, 68);
            this.EDIMinutes.MaxLength = 6;
            this.EDIMinutes.Name = "EDIMinutes";
            this.EDIMinutes.ShortcutsEnabled = false;
            this.EDIMinutes.Size = new System.Drawing.Size(43, 20);
            this.EDIMinutes.TabIndex = 33;
            this.EDIMinutes.TabStop = false;
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
            this.EDISeconds.ShortcutsEnabled = false;
            this.EDISeconds.Size = new System.Drawing.Size(43, 20);
            this.EDISeconds.TabIndex = 34;
            this.EDISeconds.TabStop = false;
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
            this.EDIHours.ShortcutsEnabled = false;
            this.EDIHours.Size = new System.Drawing.Size(43, 20);
            this.EDIHours.TabIndex = 32;
            this.EDIHours.TabStop = false;
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
            this.EDIMiliseconds.ShortcutsEnabled = false;
            this.EDIMiliseconds.Size = new System.Drawing.Size(43, 20);
            this.EDIMiliseconds.TabIndex = 35;
            this.EDIMiliseconds.TabStop = false;
            this.EDIMiliseconds.Text = "100";
            this.EDIMiliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDIMiliseconds.TextChanged += new System.EventHandler(this.EDIMiliseconds_TextChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButton.Location = new System.Drawing.Point(146, 247);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 49;
            this.ApplyButton.TabStop = false;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Location = new System.Drawing.Point(227, 247);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 280);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.CheckBox MtTCheckBox;
        public System.Windows.Forms.CheckBox EDOCheckBox;
        public System.Windows.Forms.ComboBox EDOMBDropDownList;
        private System.Windows.Forms.Label EDOMBLabel;
        public System.Windows.Forms.ComboBox EDOCTDropDownList;
        private System.Windows.Forms.Label EDOCTLabel;
        public System.Windows.Forms.CheckBox EDICheckBox;
        private System.Windows.Forms.TextBox EDIMinutes;
        private System.Windows.Forms.TextBox EDISeconds;
        private System.Windows.Forms.TextBox EDIHours;
        private System.Windows.Forms.Label EDIHoursLabel;
        private System.Windows.Forms.Label EDIMinutesLabel;
        private System.Windows.Forms.Label EDISecondsLabel;
        private System.Windows.Forms.Label EDIMilisecondsLabel;
        private System.Windows.Forms.TextBox EDIMiliseconds;
        private System.Windows.Forms.Button ApplyButton;
        public System.Windows.Forms.CheckBox DSCheckBox;
        public System.Windows.Forms.CheckBox KPoTCheckBox;
        private new System.Windows.Forms.Button CancelButton;
    }
}