using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeatStation.Services
{
    public interface IConnectServer
    {
        Task<bool> ConnectAsync(string ip,int port);
        bool SendMessage(string message);
        Task<string> AcceptMessage();
    }
}
