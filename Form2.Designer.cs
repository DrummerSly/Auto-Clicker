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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.MinimizetoTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DisableTripleCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EDISeconds = new System.Windows.Forms.TextBox();
            this.EDIHours = new System.Windows.Forms.TextBox();
            this.EnableDefaultIntervalsCheckBox = new System.Windows.Forms.CheckBox();
            this.EDIMinutes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDIMiliseconds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnableDefaultOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.EDOMouseButtonDropDownList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EDOClickTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MinimizetoTrayCheckBox
            // 
            this.MinimizetoTrayCheckBox.AutoSize = true;
            this.MinimizetoTrayCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizetoTrayCheckBox.Location = new System.Drawing.Point(172, 34);
            this.MinimizetoTrayCheckBox.Name = "MinimizetoTrayCheckBox";
            this.MinimizetoTrayCheckBox.Size = new System.Drawing.Size(102, 17);
            this.MinimizetoTrayCheckBox.TabIndex = 24;
            this.MinimizetoTrayCheckBox.Text = "Minimize to Tray";
            this.MinimizetoTrayCheckBox.UseVisualStyleBackColor = false;
            this.MinimizetoTrayCheckBox.MouseHover += new System.EventHandler(this.MinimizetoTrayCheckBox_MouseHover);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(237, 154);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(154, 154);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 26;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // DisableTripleCheckBox
            // 
            this.DisableTripleCheckBox.AutoSize = true;
            this.DisableTripleCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DisableTripleCheckBox.Location = new System.Drawing.Point(172, 12);
            this.DisableTripleCheckBox.Name = "DisableTripleCheckBox";
            this.DisableTripleCheckBox.Size = new System.Drawing.Size(90, 17);
            this.DisableTripleCheckBox.TabIndex = 36;
            this.DisableTripleCheckBox.Text = "Disable Triple";
            this.DisableTripleCheckBox.UseVisualStyleBackColor = false;
            this.DisableTripleCheckBox.MouseHover += new System.EventHandler(this.DisableTripleCheckBox_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(59, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "minutes";
            // 
            // EDISeconds
            // 
            this.EDISeconds.Enabled = false;
            this.EDISeconds.Location = new System.Drawing.Point(12, 87);
            this.EDISeconds.MaxLength = 6;
            this.EDISeconds.Name = "EDISeconds";
            this.EDISeconds.Size = new System.Drawing.Size(43, 20);
            this.EDISeconds.TabIndex = 34;
            this.EDISeconds.Text = "0";
            this.EDISeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EDIHours
            // 
            this.EDIHours.Enabled = false;
            this.EDIHours.Location = new System.Drawing.Point(12, 35);
            this.EDIHours.MaxLength = 6;
            this.EDIHours.Name = "EDIHours";
            this.EDIHours.Size = new System.Drawing.Size(43, 20);
            this.EDIHours.TabIndex = 32;
            this.EDIHours.Text = "0";
            this.EDIHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EnableDefaultIntervalsCheckBox
            // 
            this.EnableDefaultIntervalsCheckBox.AutoSize = true;
            this.EnableDefaultIntervalsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableDefaultIntervalsCheckBox.Location = new System.Drawing.Point(12, 12);
            this.EnableDefaultIntervalsCheckBox.Name = "EnableDefaultIntervalsCheckBox";
            this.EnableDefaultIntervalsCheckBox.Size = new System.Drawing.Size(139, 17);
            this.EnableDefaultIntervalsCheckBox.TabIndex = 27;
            this.EnableDefaultIntervalsCheckBox.Text = "Enable Default Intervals";
            this.EnableDefaultIntervalsCheckBox.UseVisualStyleBackColor = false;
            this.EnableDefaultIntervalsCheckBox.CheckedChanged += new System.EventHandler(this.EnableDefaultIntervalsCheckBox_CheckedChanged);
            this.EnableDefaultIntervalsCheckBox.MouseHover += new System.EventHandler(this.EnableDefaultIntervalsCheckBox_MouseHover);
            // 
            // EDIMinutes
            // 
            this.EDIMinutes.Enabled = false;
            this.EDIMinutes.Location = new System.Drawing.Point(12, 61);
            this.EDIMinutes.MaxLength = 6;
            this.EDIMinutes.Name = "EDIMinutes";
            this.EDIMinutes.Size = new System.Drawing.Size(43, 20);
            this.EDIMinutes.TabIndex = 33;
            this.EDIMinutes.Text = "0";
            this.EDIMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(59, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "hours";
            // 
            // EDIMiliseconds
            // 
            this.EDIMiliseconds.Enabled = false;
            this.EDIMiliseconds.Location = new System.Drawing.Point(12, 113);
            this.EDIMiliseconds.MaxLength = 6;
            this.EDIMiliseconds.Name = "EDIMiliseconds";
            this.EDIMiliseconds.Size = new System.Drawing.Size(43, 20);
            this.EDIMiliseconds.TabIndex = 35;
            this.EDIMiliseconds.Text = "100";
            this.EDIMiliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(59, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "miliseconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(59, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "seconds";
            // 
            // EnableDefaultOptionsCheckBox
            // 
            this.EnableDefaultOptionsCheckBox.AutoSize = true;
            this.EnableDefaultOptionsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableDefaultOptionsCheckBox.Location = new System.Drawing.Point(172, 57);
            this.EnableDefaultOptionsCheckBox.Name = "EnableDefaultOptionsCheckBox";
            this.EnableDefaultOptionsCheckBox.Size = new System.Drawing.Size(135, 17);
            this.EnableDefaultOptionsCheckBox.TabIndex = 37;
            this.EnableDefaultOptionsCheckBox.Text = "Enable Default Options";
            this.EnableDefaultOptionsCheckBox.UseVisualStyleBackColor = false;
            this.EnableDefaultOptionsCheckBox.CheckedChanged += new System.EventHandler(this.EnableDefaultOptionsCheckBox_CheckedChanged);
            this.EnableDefaultOptionsCheckBox.MouseHover += new System.EventHandler(this.EnableDefaultOptionsCheckBox_MouseHover);
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
            this.EDOMouseButtonDropDownList.Location = new System.Drawing.Point(249, 80);
            this.EDOMouseButtonDropDownList.MaxDropDownItems = 3;
            this.EDOMouseButtonDropDownList.Name = "EDOMouseButtonDropDownList";
            this.EDOMouseButtonDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOMouseButtonDropDownList.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(169, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mouse Button:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(169, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Click Type:";
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
            this.EDOClickTypeDropDownList.Location = new System.Drawing.Point(249, 109);
            this.EDOClickTypeDropDownList.MaxDropDownItems = 3;
            this.EDOClickTypeDropDownList.Name = "EDOClickTypeDropDownList";
            this.EDOClickTypeDropDownList.Size = new System.Drawing.Size(58, 21);
            this.EDOClickTypeDropDownList.TabIndex = 41;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 189);
            this.Controls.Add(this.EDOClickTypeDropDownList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EDOMouseButtonDropDownList);
            this.Controls.Add(this.EnableDefaultOptionsCheckBox);
            this.Controls.Add(this.EnableDefaultIntervalsCheckBox);
            this.Controls.Add(this.DisableTripleCheckBox);
            this.Controls.Add(this.EDIMiliseconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EDIHours);
            this.Controls.Add(this.EDISeconds);
            this.Controls.Add(this.EDIMinutes);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MinimizetoTrayCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox MinimizetoTrayCheckBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.CheckBox DisableTripleCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDISeconds;
        private System.Windows.Forms.TextBox EDIHours;
        public System.Windows.Forms.CheckBox EnableDefaultIntervalsCheckBox;
        private System.Windows.Forms.TextBox EDIMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDIMiliseconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox EnableDefaultOptionsCheckBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox EDOMouseButtonDropDownList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox EDOClickTypeDropDownList;
    }
}
