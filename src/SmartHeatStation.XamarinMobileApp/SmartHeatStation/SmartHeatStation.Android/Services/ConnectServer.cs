using System.Threading.Tasks;
using Xamarin.Forms;
using SocketCom;

[assembly: Dependency(typeof(SmartHeatStation.Droid.Services.ConnectServer))]
namespace SmartHeatStation.Droid.Services
{
    class ConnectServer : SmartHeatStation.Services.IConnectServer
    {
        Client client;
        public Task<string> AcceptMessage()
        {
            throw (null);
        }

        public async Task<bool> ConnectAsync(string ip, int port)
        {
            client = new Client();
            var result = await Task.Run(() =>
            {
                return client.Connection(ip, port);
            });
            if (result == false)
                client = null;
            return await Task.FromResult(result);

        }

        public bool SendMessage(string message)
        {
            if(client != null)
                return client.SendDataForServer(message);
            return false;
        }

    }
}