using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;

namespace blynk
{
    public partial class RoomLightForm : Form
    {
        public RoomLightForm()
        {
            InitializeComponent();
        }
        string url;

        static Boolean isOnlineBool = false;

        int switchPower;    //总开关
        int switchColor;    //彩虹控制开关
        int r, g, b, light;     //RGB值和亮度控制

        /*******************************************************************
         * load方法中检验硬件是否在线
         *******************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            url = ConfigurationManager.AppSettings[AppconfigKeysClass.urlKey];
            // 启动先测试硬件是否在线
            IsOnline();
            if(isOnlineBool)
                Init();
            
        }

        /*******************************************************************
         * 电源按钮事件
         *******************************************************************/
        private void powerButton_Click(object sender, EventArgs e)
        {
            if (isOnlineBool)
            {
                if (switchPower == 1)        //处于打开状态则关闭
                {
                    GetRequestOnly(url + "update/V0?value=0");
                    switchPower = 0;
                    buttonPower.Text = "开";
                }
                else if (switchPower == 0)   //处于关闭状态则开启
                {
                    GetRequestOnly(url + "update/V0?value=1");
                    switchPower = 1;
                    buttonPower.Text = "关";
                }
            }
        }
        /*******************************************************************
        * 彩虹按钮事件
        *******************************************************************/
        private void colorButton_Click(object sender, EventArgs e)
        {
            if (isOnlineBool)
            {
                if (switchColor == 1)        //处于打开状态则关闭
                {
                    GetRequestOnly(url + "update/V4?value=0");
                    switchColor = 0;
                    buttonColor.Text = "关";
                }
                else if (switchColor == 0)   //处于关闭状态则开启
                {
                    GetRequestOnly(url + "update/V4?value=1");
                    switchColor = 1;
                    buttonColor.Text = "开";
                }
            }
        }
        /*******************************************************************
         * 在滑动条value修改时，并且硬件在线
         * 发送修改请求
         *******************************************************************/
        private void trackBarR_MouseUp(object sender, MouseEventArgs e)
        {
            if (isOnlineBool)
            {
                GetRequestOnly(url + "update/V1?value=" + trackBar_R.Value);
                label_R.Text = trackBar_R.Value.ToString();
            }
        }

        private void trackBar_L_MouseUp(object sender, MouseEventArgs e)
        {
            if (isOnlineBool)
            {
                GetRequestOnly(url + "update/V5?value=" + trackBar_L.Value);
                label_L.Text = trackBar_L.Value.ToString();
            }
        }

        private void trackBar_G_MouseUp(object sender, MouseEventArgs e)
        {
            if (isOnlineBool)
            {
                GetRequestOnly(url + "update/V2?value=" + trackBar_G.Value);
                label_G.Text = trackBar_G.Value.ToString();
            }
        }

        private void trackBar_B_MouseUp(object sender, MouseEventArgs e)
        {
            if (isOnlineBool)
            {
                GetRequestOnly(url + "update/V3?value=" + trackBar_B.Value);
                label_B.Text = trackBar_B.Value.ToString();
            }
        }


        /*******************************************************************
        * 刷新硬件在线状态，
        * 如果在线，获取硬件当前状态
        *******************************************************************/
        private void isOnlineTimer_Tick(object sender, EventArgs e)
        {

            IsOnline();
            if(isOnlineBool)
                Init();
        }

        /*******************************************************************
        **硬件在线，获取当前硬件各虚拟端口的值
        *******************************************************************/
        private void Init()     
        {
            GetResultAndUpdateUI(url + "get/V0", UpdatePowerSwitch);
            GetResultAndUpdateUI(url + "get/V4", UpdateColorSwitch);
            GetResultAndUpdateUI(url + "get/V1", UpdateColorTrackBar);
            GetResultAndUpdateUI(url + "get/V5", UpdateLightTrackBar);
        }
        /*******************************************************************
        * 异步网络请求
        * 分为可以在主界面更新和不需要更新
        *******************************************************************/
        // 只发送请求
        private void GetRequestOnly(string url)
        {
            DealRequest dealPower = new DealRequest();

            Thread threadPower = new Thread(new ParameterizedThreadStart(dealPower.DealRequestRunner));
            threadPower.IsBackground = true;
            threadPower.Start(url);
        }
        // 发送请求并需要修改UI界面
        private void GetResultAndUpdateUI(string url, DealRequest.UpdateUI updateUI)
        {
            DealRequest dealPower = new DealRequest();
            dealPower.UpdateUIDelegate += updateUI;

            Thread threadPower = new Thread(new ParameterizedThreadStart(dealPower.DealRequestDelegateRunner));
            threadPower.IsBackground = true;
            threadPower.Start(url);
        }
        /*******************************************************************
        * 查询Server内各数据的值，并更新在UI界面
        *******************************************************************/
        // 更新亮度滑动条显示
        private void UpdateLightTrackBar(string result)
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action<string>(n =>
                {
                    if (result != "")
                    {
                        result = Conversion(result);
                        light = Convert.ToInt32(result);
                        trackBar_L.Value = light;

                        label_L.Text = light.ToString();
                    }
                }),result);
            }
            
        }
        // 更新三原色滑动条显示
        private void UpdateColorTrackBar(string result)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(n => {
                    if (result != "")
                    {
                        result = Conversion(result);
                        string[] strs = result.Split(',');
                        r = Convert.ToInt32(strs[0]);
                        g = Convert.ToInt32(strs[1]);
                        b = Convert.ToInt32(strs[2]);

                        //将滑动条的值与开发板的值同步
                        trackBar_R.Value = r;
                        trackBar_G.Value = g;
                        trackBar_B.Value = b;

                        label_R.Text = r.ToString();
                        label_G.Text = g.ToString();
                        label_B.Text = b.ToString();
                    }
                }), result);
                
            }
        }

        // 更新彩虹按钮显示
        private void UpdateColorSwitch(string result)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(n =>
                {
                    if (result != "")
                    {
                        result = Conversion(result);
                        switchColor = Convert.ToInt32(result);
                        if (switchColor == 0)
                            buttonColor.Text = "开";
                        else if (switchPower == 1)
                            buttonColor.Text = "关";
                    }
                }), result);
            }
            
        }
        // 更新电源按钮显示
        private void UpdatePowerSwitch(string result)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(n =>
                {
                    if (result != "")
                    {
                        result = Conversion(result);
                        switchPower = Convert.ToInt32(result);
                        //MessageBox.Show(result + "\n" + switchPower.ToString());
                        if (switchPower == 0)
                            buttonPower.Text = "开";
                        else if (switchPower == 1)
                            buttonPower.Text = "关";
                    }
                }), result);
            }
            
        }

        /*******************************************************************
        * 跳转到设置窗口
        *******************************************************************/
        // 设置窗口打开事件
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            DialogResult dialogResult = settingForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                this.Form1_Load(null, null);
            }

        }
        /*******************************************************************
        * 勾选框事件
        * 勾选后定时器失效，将在线状态字改为true
        *******************************************************************/
        private void checkBox1_Online_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Online.Checked)
            {
                isOnlineTimer.Stop();
                isOnlineBool = true;
                Init();
            }
            else
            {
                IsOnline();
                isOnlineTimer.Start();
            }
        }


        /*******************************************************************
         * 转化接受到的字符串
         * 去除括号和引号，并将引号内的内容去出
         *******************************************************************/
        private string Conversion(string msg)
        {
            string str = "";
            bool b1 = false;
            bool b2 = false;
            int index = 0;
            if (msg[index] == '[')
                b1 = true;
            while(b1)
            {
                if (msg[index] == '"')
                {
                    b2 = !b2;
                }
                else if (msg[index] == ']')
                    b1 = false;
                else if (msg[index] == ',')
                    str += ',';
                else
                {
                    if (b2)
                        str += msg[index];
                }
                index++;
            }
            return str;
        }

        /*******************************************************************
         * 查看硬件是否在线，
         * 在线才能发送控制指令
         *******************************************************************/
        private void IsOnline()
        {
            // 使用委托异步操作UI
            GetResultAndUpdateUI(url + "isHardwareConnected", UpdateIsOnline);

        }
        // 修改状态图标
        private void UpdateIsOnline(string result)
        {
            isOnlineBool = result == "true" ? true : false;
            if(isOnlineBool)
            {
                isOnlinePictureBox1.Image = Properties.Resources.online;
            }
            else
            {
                isOnlinePictureBox1.Image = Properties.Resources.offline;
            }
        }


    }
}
