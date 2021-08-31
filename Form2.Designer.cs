
namespace autoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.OKButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.MinimizetoTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.Location = new System.Drawing.Point(12, 44);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButton.Enabled = false;
            this.ApplyButton.Location = new System.Drawing.Point(123, 44);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(97, 23);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // MinimizetoTrayCheckBox
            // 
            this.MinimizetoTrayCheckBox.AutoSize = true;
            this.MinimizetoTrayCheckBox.Checked = true;
            this.MinimizetoTrayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimizetoTrayCheckBox.Location = new System.Drawing.Point(64, 12);
            this.MinimizetoTrayCheckBox.Name = "MinimizetoTrayCheckBox";
            this.MinimizetoTrayCheckBox.Size = new System.Drawing.Size(102, 17);
            this.MinimizetoTrayCheckBox.TabIndex = 2;
            this.MinimizetoTrayCheckBox.Text = "Minimize to Tray";
            this.MinimizetoTrayCheckBox.UseVisualStyleBackColor = true;
            this.MinimizetoTrayCheckBox.CheckedChanged += new System.EventHandler(this.MinimizetoTrayCheckBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 78);
            this.Controls.Add(this.MinimizetoTrayCheckBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Cilcker Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.CheckBox MinimizetoTrayCheckBox;
    }
}