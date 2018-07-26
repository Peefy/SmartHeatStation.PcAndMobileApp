using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using SmartHeatStation.Helper;

[assembly: Dependency(typeof(SmartHeatStation.Services.DiaLogService))]
namespace SmartHeatStation.Services
{
    class DiaLogService : IDialogService
    {
        public async Task ShowAlertAsync(string message)
        {
            await Apphelper.HomeTabPage.DisplayAlert("系统消息", message, "知道了");
        }

        public async Task<bool> ShowAlertAsync(string title, string quest)
        {
            var result = await Apphelper.HomeTabPage.DisplayAlert(title,quest, "确认","取消");
            return await Task.FromResult(result);
        }

        public async Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            //await UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
            await Apphelper.HomeTabPage.DisplayAlert(title,message,buttonLabel);
        }

        public void Toast(string message)
        {
            //UserDialogs.Instance.Toast(new ToastConfig(message)
            //{
            //    MessageTextColor = System.Drawing.Color.Red,
            //    Duration = TimeSpan.FromSeconds(1.2),
            //    BackgroundColor = System.Drawing.Color.White
            //});
        }

    }
}
