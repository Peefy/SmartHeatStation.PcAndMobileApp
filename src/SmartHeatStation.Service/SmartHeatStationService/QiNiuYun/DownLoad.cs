using System.Net;
using System.Windows.Forms;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;
using System;

namespace QiniuYun
{
    class DownLoad
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public string GetURLResult(string strUrl)
        {
            string strMsg = "";
            try
            {
                WebRequest request = WebRequest.Create(strUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));

                strMsg = reader.ReadToEnd();

                reader.Close();
                reader.Dispose();
                response.Close();
            }
            catch
            { }
            return strMsg;
        }
        /// <summary>
        /// 
        /// </summary>
        public void DownFileTest()
        {
            Util.SetCertificatePolicy();
            //WebClient client = new WebClient();
            //string pathURL = "https://oios713sb.bkt.clouddn.com/test2.txt";
            //string pathDest = @"f:\test.txt";
            //string vars =  client.DownloadString(pathURL);
            var str = CallWebPage("https://oios713sb.bkt.clouddn.com/my.txt",3000, Encoding.GetEncoding("gb2312"));
            MessageBox.Show(str);

        }
        /// <summary>
        /// 
        /// </summary>
        public static class Util
        {
            /// <summary>
            /// Sets the cert policy.
            /// </summary>
            public static void SetCertificatePolicy()
            {
                ServicePointManager.ServerCertificateValidationCallback
                           += RemoteCertificateValidate;
            }

            /// <summary>
            /// Remotes the certificate validate.
            /// </summary>
            private static bool RemoteCertificateValidate(
                object sender, X509Certificate cert,
                 X509Chain chain, SslPolicyErrors error)
            {
                // trust any certificate!!!
                System.Console.WriteLine("Warning, trust any certificate");
                return true;
            }
        }

        /// 访问URL地址
        public string CallWebPage(string url, int httpTimeout, Encoding postEncoding)

        {

            string rStr = "";

            System.Net.WebRequest req = null;

            System.Net.WebResponse resp = null;

            System.IO.Stream os = null;

            System.IO.StreamReader sr = null;

            try

            {

                //创建连接

                req = System.Net.WebRequest.Create(url);

                req.ContentType = "application/x-www-form-urlencoded";

                req.Method = "GET";

                //时间

                if (httpTimeout > 0)

                {

                    req.Timeout = httpTimeout;

                }

                //读取返回结果

                resp = req.GetResponse();

                sr = new System.IO.StreamReader(resp.GetResponseStream(), postEncoding);

                rStr = sr.ReadToEnd();


            }

            catch (Exception ex)

            {

                throw (ex);

            }

            finally

            {

                try

                {

                    //关闭资源

                    if (os != null)

                    {

                        os.Dispose();

                        os.Close();

                    }

                    if (sr != null)

                    {

                        sr.Dispose();

                        sr.Close();

                    }

                    if (resp != null)

                    {

                        resp.Close();

                    }

                    if (req != null)

                    {

                        req.Abort();

                        req = null;

                    }

                }

                catch (Exception ex2)
                {

                    throw (ex2);
                }

            }

            return rStr;

        }

    }
}
