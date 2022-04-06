
namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.STextBox = new System.Windows.Forms.TextBox();
            this.MiTextBox = new System.Windows.Forms.TextBox();
            this.CTDropDownList = new System.Windows.Forms.ComboBox();
            this.MBDropDownList = new System.Windows.Forms.ComboBox();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.HTextBox);
            groupBox1.Controls.Add(this.MTextBox);
            groupBox1.Controls.Add(this.STextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(this.MiTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // HTextBox
            // 
            resources.ApplyResources(this.HTextBox, "HTextBox");
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.TextChanged += new System.EventHandler(this.HTextBox_TextChanged);
            // 
            // MTextBox
            // 
            resources.ApplyResources(this.MTextBox, "MTextBox");
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.TextChanged += new System.EventHandler(this.MTextBox_TextChanged);
            // 
            // STextBox
            // 
            resources.ApplyResources(this.STextBox, "STextBox");
            this.STextBox.Name = "STextBox";
            this.STextBox.TextChanged += new System.EventHandler(this.STextBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // MiTextBox
            // 
            resources.ApplyResources(this.MiTextBox, "MiTextBox");
            this.MiTextBox.Name = "MiTextBox";
            this.MiTextBox.TextChanged += new System.EventHandler(this.MiTextBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(this.CTDropDownList);
            groupBox2.Controls.Add(this.MBDropDownList);
            groupBox2.Controls.Add(label8);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Name = "label1";
            // 
            // CTDropDownList
            // 
            this.CTDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTDropDownList.FormattingEnabled = true;
            this.CTDropDownList.Items.AddRange(new object[] {
            resources.GetString("CTDropDownList.Items"),
            resources.GetString("CTDropDownList.Items1")});
            resources.ApplyResources(this.CTDropDownList, "CTDropDownList");
            this.CTDropDownList.Name = "CTDropDownList";
            this.CTDropDownList.SelectedIndexChanged += new System.EventHandler(this.CTDropDownList_SelectedIndexChanged);
            // 
            // MBDropDownList
            // 
            this.MBDropDownList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MBDropDownList.FormattingEnabled = true;
            this.MBDropDownList.Items.AddRange(new object[] {
            resources.GetString("MBDropDownList.Items"),
            resources.GetString("MBDropDownList.Items1"),
            resources.GetString("MBDropDownList.Items2")});
            resources.ApplyResources(this.MBDropDownList, "MBDropDownList");
            this.MBDropDownList.Name = "MBDropDownList";
            this.MBDropDownList.SelectedIndexChanged += new System.EventHandler(this.MBDropDownList_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Name = "label8";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.OptionsButton, "OptionsButton");
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Name = "StopButton";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.NotifyIcon, "NotifyIcon");
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.TextBox STextBox;
        private System.Windows.Forms.TextBox MiTextBox;
        public System.Windows.Forms.ComboBox CTDropDownList;
        private System.Windows.Forms.ComboBox MBDropDownList;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
    }
}

