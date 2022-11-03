namespace blynk
{
    partial class RoomLightForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomLightForm));
            this.isOnlineTimer = new System.Windows.Forms.Timer(this.components);
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.isOnlinePictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_L = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_B = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_L = new System.Windows.Forms.TrackBar();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_Online = new System.Windows.Forms.CheckBox();
            this.controlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isOnlinePictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isOnlineTimer
            // 
            this.isOnlineTimer.Enabled = true;
            this.isOnlineTimer.Interval = 2000;
            this.isOnlineTimer.Tick += new System.EventHandler(this.isOnlineTimer_Tick);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroupBox.Controls.Add(this.checkBox_Online);
            this.controlGroupBox.Controls.Add(this.isOnlinePictureBox1);
            this.controlGroupBox.Controls.Add(this.label6);
            this.controlGroupBox.Controls.Add(this.label_L);
            this.controlGroupBox.Controls.Add(this.label5);
            this.controlGroupBox.Controls.Add(this.groupBox1);
            this.controlGroupBox.Controls.Add(this.label4);
            this.controlGroupBox.Controls.Add(this.trackBar_L);
            this.controlGroupBox.Controls.Add(this.buttonColor);
            this.controlGroupBox.Controls.Add(this.buttonPower);
            this.controlGroupBox.Location = new System.Drawing.Point(12, 28);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(395, 363);
            this.controlGroupBox.TabIndex = 6;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "控制";
            // 
            // isOnlinePictureBox1
            // 
            this.isOnlinePictureBox1.Image = global::blynk.Properties.Resources.del;
            this.isOnlinePictureBox1.Location = new System.Drawing.Point(153, 21);
            this.isOnlinePictureBox1.Name = "isOnlinePictureBox1";
            this.isOnlinePictureBox1.Size = new System.Drawing.Size(72, 71);
            this.isOnlinePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isOnlinePictureBox1.TabIndex = 14;
            this.isOnlinePictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "彩虹模式";
            // 
            // label_L
            // 
            this.label_L.AutoSize = true;
            this.label_L.Location = new System.Drawing.Point(314, 110);
            this.label_L.Name = "label_L";
            this.label_L.Size = new System.Drawing.Size(11, 12);
            this.label_L.TabIndex = 10;
            this.label_L.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "开关";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_B);
            this.groupBox1.Controls.Add(this.label_G);
            this.groupBox1.Controls.Add(this.label_R);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_B);
            this.groupBox1.Controls.Add(this.trackBar_G);
            this.groupBox1.Controls.Add(this.trackBar_R);
            this.groupBox1.Location = new System.Drawing.Point(31, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 162);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(281, 126);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(11, 12);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "0";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(281, 72);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(11, 12);
            this.label_G.TabIndex = 3;
            this.label_G.Text = "0";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(281, 19);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(11, 12);
            this.label_R.TabIndex = 3;
            this.label_R.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "R";
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(59, 111);
            this.trackBar_B.Maximum = 255;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(218, 45);
            this.trackBar_B.TabIndex = 1;
            this.trackBar_B.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_B_MouseUp);
            // 
            // trackBar_G
            // 
            this.trackBar_G.Location = new System.Drawing.Point(59, 60);
            this.trackBar_G.Maximum = 255;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(218, 45);
            this.trackBar_G.TabIndex = 1;
            this.trackBar_G.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_G_MouseUp);
            // 
            // trackBar_R
            // 
            this.trackBar_R.Location = new System.Drawing.Point(59, 9);
            this.trackBar_R.Maximum = 255;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.Size = new System.Drawing.Size(218, 45);
            this.trackBar_R.TabIndex = 1;
            this.trackBar_R.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarR_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "亮度";
            // 
            // trackBar_L
            // 
            this.trackBar_L.Location = new System.Drawing.Point(90, 102);
            this.trackBar_L.Maximum = 255;
            this.trackBar_L.Name = "trackBar_L";
            this.trackBar_L.Size = new System.Drawing.Size(218, 45);
            this.trackBar_L.TabIndex = 8;
            this.trackBar_L.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_L_MouseUp);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(304, 33);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(55, 59);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "开";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(31, 33);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(55, 59);
            this.buttonPower.TabIndex = 7;
            this.buttonPower.Text = "开";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem.Text = "选项";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SettingToolStripMenuItem.Text = "设置";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // checkBox_Online
            // 
            this.checkBox_Online.AutoSize = true;
            this.checkBox_Online.Location = new System.Drawing.Point(31, 321);
            this.checkBox_Online.Name = "checkBox_Online";
            this.checkBox_Online.Size = new System.Drawing.Size(180, 16);
            this.checkBox_Online.TabIndex = 8;
            this.checkBox_Online.Text = "忽略硬件是否在线，直接修改";
            this.checkBox_Online.UseVisualStyleBackColor = true;
            this.checkBox_Online.CheckedChanged += new System.EventHandler(this.checkBox1_Online_CheckedChanged);
            // 
            // RoomLightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 403);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RoomLightForm";
            this.Text = "卧室小灯";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isOnlinePictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer isOnlineTimer;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.PictureBox isOnlinePictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_B;
        private System.Windows.Forms.TrackBar trackBar_G;
        private System.Windows.Forms.TrackBar trackBar_R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_L;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_Online;
    }
}

