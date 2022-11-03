namespace blynk
{
    partial class SettingForm
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
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.settingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(81, 27);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(240, 21);
            this.serverTextBox.TabIndex = 0;
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingGroupBox.AutoSize = true;
            this.settingGroupBox.Controls.Add(this.label3);
            this.settingGroupBox.Controls.Add(this.button);
            this.settingGroupBox.Controls.Add(this.label1);
            this.settingGroupBox.Controls.Add(this.serverTextBox);
            this.settingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(353, 220);
            this.settingGroupBox.TabIndex = 0;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器地址：";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(0, 150);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(321, 29);
            this.button.TabIndex = 1;
            this.button.Text = "确定";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "请在服务器地址后面输入Blynk服务器的地址，例如：\r\nhttp://blynk-cloud.com/c20b792a8b464a02a40e6f0392279b" +
    "71/\r\n注意，请按照该格式填写，网址最后请加上 / \r\n";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 234);
            this.Controls.Add(this.settingGroupBox);
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}