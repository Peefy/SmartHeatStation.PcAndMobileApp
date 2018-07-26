
using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.Droid.Services.DownLoad))]
namespace SmartHeatStation.Droid.Services
{
    class DownLoad : SmartHeatStation.Services.IDownLoad
    {

        public async Task<string> DownLoadString(string url)
        {
            var str = await Task.Run(() => {
                try
                {
                    return new WebClient().DownloadString(new Uri(url));
                }
                catch (Exception)
                {
                    return "Error";
                }
                
            });
            return await Task.FromResult(str);
        }

    }
}