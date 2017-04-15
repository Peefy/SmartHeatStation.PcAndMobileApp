using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SocketCom
{
    public class Client
    {

        const int DefaultPortId = 8181;
        const string DefaultHostIp = "192.168.223.206";

        /// <summary>
        /// 客户端的名称
        /// </summary>
        public string Name;
        public TcpClient client;
        /// <summary>
        /// 所有用户是否已准备
        /// </summary>
        public bool everyIsOk = false;
        /// <summary>
        /// 每次发送数据延迟时间(毫秒)
        /// </summary>
        public int sleep = 100;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Client()
        {
            client = new TcpClient();
        }

        /// <summary>
        /// 向服务器发送连接请求
        /// </summary>
        public bool Connection()
        {
            try
            {
                client.Connect(IPAddress.Parse(DefaultHostIp), DefaultPortId);
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
            try
            {
                NetworkStream Ns = this.client.GetStream();
                byte[] bytes = Encoding.Default.GetBytes(str);
                Ns.Write(bytes, 0, bytes.Length);
                Thread.Sleep(sleep);
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
