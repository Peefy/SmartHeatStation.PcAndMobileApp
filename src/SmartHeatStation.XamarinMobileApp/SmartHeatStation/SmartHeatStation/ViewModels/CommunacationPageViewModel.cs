using SmartHeatStation.Helper;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class CommunacationPageViewModel : ViewModelBase
    {
        const string url = "http://oios713sb.bkt.clouddn.com/";
        
        protected readonly Services.IDownLoad DownLoadService;

        public CommunacationPageViewModel()
        {
            DownLoadService = DependencyService.Get<Services.IDownLoad>();
            Title = "通信设置";
        }

        #region IpString
        string ipString = "192.168.223.195";
        public string IpString
        {
            get { return ipString; }
            set { SetProperty(ref ipString, value); }
        }
        #endregion

        #region DownLoadInterval

        string downLoadInterval = "28";
        public string DownLoadInterval
        {
            get { return downLoadInterval; }
            set { SetProperty(ref downLoadInterval, value); }
        }

        #endregion

        #region ConnectServerCommand
        public ICommand ConnectServerCommand => new Command(OnConnectServer);

        async void OnConnectServer(object obj)
        {
            var result = await ConnectService.ConnectAsync(IpString, 8181);
            string strResult = result == true ? "连接成功！" : "连接失败";
            await DialogService.ShowAlertAsync(strResult,"连接PC服务器结果","知道了");
        }

        #endregion

        #region SendCommand
        public ICommand SendCommand => new Command(OnSendToServer);

        async void OnSendToServer(object obj)
        {
            var result = ConnectService.SendMessage("OK");
            await DialogService.ShowAlertAsync("发送的数据为：OK");
        }
        #endregion

        #region DownLoadCommand
        public ICommand DownLoadCommand => new Command(OnDownLoad);

        async void OnDownLoad(object obj)
        {
            string realURL = url + "my" + TimerHelper.GetUpLoadTime() + ".txt";
            //string realURL = url + "my2017030516184.txt";
            var str = await DownLoadService.DownLoadString(realURL);
            if (str != "Error")
                ReceiveText = "标定次数：" + str;
            else
                ReceiveText = "获取中...";
        }


        #endregion

        #region ReceiveText
        string receiveText = "下载数据";
        public string ReceiveText
        {
            get { return receiveText; }
            set { SetProperty(ref receiveText, value); }
        }

        #endregion
    }
}
