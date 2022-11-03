using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace blynk
{
    class DealRequest
    {
        public DealRequest() {  }

        public delegate void UpdateUI(string result);//声明一个更新主线程的委托
        public UpdateUI UpdateUIDelegate;

        public void DealRequestDelegateRunner(object url)
        {
            UpdateUIDelegate(Get((string)url));
        }

        public void DealRequestRunner(object url)
        {
            Get((string)url);
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
    }
}
