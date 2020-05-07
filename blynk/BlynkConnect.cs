using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace blynk
{
    class BlynkConnect
    {
        public string Url { get; set; }     //服务地址
        public string Auth { get; set; }    //应用的auth码
        /*
         *  1个参数构造，默认为blynk官方服务器
         */
        public BlynkConnect(string auth)
        {
            Url = "http://blynk-cloud.com/";     
            Auth = auth;
        }
        /*
         * 自定义服务器和应用码，
         * 样例输入 （"http://blynk-cloud.com/","fuioasdgjfd"）
         */
        public BlynkConnect(string url,string auth)
        {
            Url = url;
            Auth = auth;
        }
        /*
         *检测硬件是否在线的方法
         */
        public bool HardwareIsOnline()
        {
            if (Get(Url +Auth+ "/isHardwareConnected") == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         *检测应用端是否在线的方法
         */
        public bool ApplicationIsOnline()
        {
            if(Get(Url + Auth + "/isAppConnected") == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         *获取引脚当前值
         * 样例输入 （“V1”） 虚拟引脚1的值
         */
        public string[] GetPinValue(string pin)
        {
            string response = Conversion(Get(Url + Auth + "/get/" + pin));
            string[] pinDatas = response.Split(',');
            return pinDatas;
        }

        /*
         *设置引脚值
         */
        public bool SetPinValue(string pin,string value)
        {
            if (Get(Url + Auth + "/update/" + pin + "?value=" + value) == "")
                return true;
            return false;
        }

        /*
         *发送推送通知
         */
        public void SendPushNotification(string msg)
        {
            PostHttp(Url + Auth + "/notify", "{body:" + msg + "}");
        }
        /*
         *发送email
         * {
         *      to:email,   要发生的地址
         *      title:title,    标题
         *      subj:subj       正文
         * }
         */
        public void SendEmail(string email,string title,string sbj)
        {
            PostHttp(Url + Auth + "/email", "{to:" + email + ",title:" + title + ",sbj:" + sbj + "}");
        }
        /*
         *获取工程信息
         */
        public string GetProject()
        {
            return Get(Url + Auth + "/project");
        }



        /*******************************************************************
         * 转化接受到的字符串
         * 去除括号和引号，并将引号内的内容取出
         *******************************************************************/
        private string Conversion(string msg)
        {
            string str = "";
            bool b1 = false;
            bool b2 = false;
            int index = 0;
            //检测是否返回错误
            if (msg[index] == '[')
                b1 = true;
            while (b1)
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
         **发起GET网络请求
         *******************************************************************/
        private static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            if (resp.StatusCode != HttpStatusCode.OK)
                return "error" + resp.StatusCode.ToString();
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
        **发起POST网络请求
        * bady "{a:1,b:2}"
        *******************************************************************/
        public string PostHttp(string url ,string body)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Timeout = 20000;

            byte[] btBodys = Encoding.UTF8.GetBytes(body);
            httpWebRequest.ContentLength = btBodys.Length;
            httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();

            httpWebResponse.Close();
            streamReader.Close();
            httpWebRequest.Abort();
            httpWebResponse.Close();

            return responseContent;
        }
    }
}
