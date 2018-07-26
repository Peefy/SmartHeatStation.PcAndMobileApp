using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.iOS.Services.DownLoad))]
namespace SmartHeatStation.iOS.Services
{
    class DownLoad : SmartHeatStation.Services.IDownLoad
    {

        public async Task<string> DownLoadString(string url)
        {
            //Util.SetCertificatePolicy();
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

    }
}