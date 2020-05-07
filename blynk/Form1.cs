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
using System.Windows.Forms;

namespace blynk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string url = "http://blynk-cloud.com/c20b792a8b464a02a40e6f0392279b71/";
        int switch1;    //总开关
        int switch2;    //彩虹控制开关
        int r, g, b, light;     //RGB值和亮度控制
        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsOnline())  //硬件端是否在线
            {
                Init();      //获取硬件状态信息
            }
        }
        /*******************************************************************
         * 按钮事件，
         * 按钮1 控制硬件开关
         * 按钮2 控制彩虹按钮
         *******************************************************************/
        private void Button1_Click(object sender, EventArgs e)
        {
            if(switch1 == 1)        //处于打开状态则关闭
            {
                Get(url + "update/V0?value=0");
                switch1 = 0;
                button1.Text = "关";
            }
            else if(switch1 == 0)   //处于关闭状态则开启
            {
                Get(url + "update/V0?value=1");
                switch1 = 1;
                button1.Text = "开";
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (switch2 == 1)        //处于打开状态则关闭
            {
                Get(url + "update/V4?value=0");
                switch2 = 0;
                button2.Text = "关";
            }
            else if (switch2 == 0)   //处于关闭状态则开启
            {
                Get(url + "update/V4?value=1");
                switch2 = 1;
                button2.Text = "开";
            }
        }
        /*******************************************************************
         * 在滑动条value修改时，并且硬件在线
         * 发送修改请求
         *******************************************************************/
        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Get(url + "update/V1?value=" + trackBar1.Value);
                label7.Text = trackBar1.Value.ToString();
            }
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Get(url + "update/V2?value=" + trackBar2.Value);
                label8.Text = trackBar2.Value.ToString();
            }
        }

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Get(url + "update/V3?value=" + trackBar3.Value);
                label9.Text = trackBar3.Value.ToString();
            }
        }
        private void TrackBar4_ValueChanged(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Get(url + "update/V5?value=" + trackBar4.Value);
                label10.Text = trackBar4.Value.ToString();
            }
        }


        /*******************************************************************
         **发起GET网络请求
         *******************************************************************/
        private static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }
        /*******************************************************************
        * 刷新硬件在线状态，
        * 如果在线，获取硬件当前状态
        *******************************************************************/
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(IsOnline())
            {
                Init();
            }
        }

        /*******************************************************************
        **硬件在线，获取当前硬件各虚拟端口的值
        *******************************************************************/
        private void Init()     
        {
            string s1 = Get(url + "get/V0");    //获取主开关值
            string s2 = Get(url + "get/V4");    //获取彩虹开关值
            string rgb = Get(url + "get/V1");   //获取RGB颜色值
            string l = Get(url + "get/V5");
            if(s1 != "")
            {
                s1 = Conversion(s1);
                switch1 = Convert.ToInt32(s1);
                if (switch1 == 0)
                    button1.Text = "关";
                else if (switch1 == 1)
                    button1.Text = "开";
            }
            if(s2 != "")
            {
                s2 = Conversion(s2);
                switch2 = Convert.ToInt32(s2);
                if (switch2 == 0)
                    button2.Text = "关";
                else if (switch1 == 1)
                    button2.Text = "开";
            }
            if(rgb != "")
            {
                rgb = Conversion(rgb);
                string[] strs = rgb.Split(',');
                r = Convert.ToInt32(strs[0]);
                g = Convert.ToInt32(strs[1]);
                b = Convert.ToInt32(strs[2]);
            }
            if(l != "")
            {
                l = Conversion(l);
                light = Convert.ToInt32(l);
            }
            //将滑动条的值与开发板的值同步
            trackBar1.Value = r;
            trackBar2.Value = g;
            trackBar3.Value = b;
            trackBar4.Value = light;
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
        private bool IsOnline()
        {
            if (Get(url + "isHardwareConnected") == "true")  //硬件端是否在线
            {
                pictureBox1.Image = Image.FromFile("../../imgs/online.png");
                return true;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../imgs/offline.png");
                return false;
            }
        }
    }
}
