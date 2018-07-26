using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketCom
{
    public class Client
    {

        const int DefaultPortId = 8181;
        const string DefaultHostIp = "192.168.223.206";  //局域网内网PC的IP地址
        public string ConnectIpString { get; set; } = "192.168.223.206";
        /// <summary>
        /// 客户端的名称
        /// </summary>
        public string Name { get; set; } = "DuGuName";
        TcpClient client { get; set; }
        /// <summary>
        /// 所有用户是否已准备
        /// </summary>
        public bool EveryIsOk { get; set; } = false;
        /// <summary>
        /// 每次发送数据延迟时间(毫秒)
        /// </summary>
        public int SleepTime  { get; set; } = 100;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Client()
        {
            client = new TcpClient();
        }

        /// <summary>
        /// 向服务器发送连接
        /// </summary>
        public bool Connection(string ip,int port)
        {
            try
            {
                client.Connect(IPAddress.Parse(ip), port);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 接收服务器发送的数据
        /// </summary>
        public void AcceptServerData() 
        {
            NetworkStream Ns = client.GetStream();
            string str = "";
            while (true)
            {
                byte[] bytes = new byte[108];
                Ns.Read(bytes, 0, 108);
                str = Encoding.Default.GetString(bytes);
                if (str.StartsWith("StartPokers", StringComparison.Ordinal))
                {
                    str = str.Replace("StartPokers", "");
                    str.Trim();
                    byte[] bytePokers = Encoding.Default.GetBytes(str);
                    continue;
                }
            }
        }

        /// <summary>
        /// 向服务器发送准备请求
        /// </summary>
        public bool SendOk() //给服务器发送准备指令
        {
            this.SendDataForServer("OK");
            return true;
        }

        /// <summary>
        /// 向服务器发送出牌请求
        /// </summary>
        public bool SendDataForServer(string str)
        {
            NetworkStream Ns = this.client.GetStream();
            byte[] bytes = Encoding.Default.GetBytes(str);
            Ns.Write(bytes, 0, bytes.Length);
            Thread.Sleep(SleepTime);
            return true;
        }

    }
}
