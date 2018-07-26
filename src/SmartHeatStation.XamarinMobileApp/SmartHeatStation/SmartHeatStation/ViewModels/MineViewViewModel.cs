using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHeatStation.Helper;
using SmartHeatStation.Pages;

using Xamarin.Forms;


namespace SmartHeatStation.ViewModels
{
    public class MineViewViewModel : ViewModelBase
    {
        string userNameId = PropertiesHelper.Get<string>(RegisterPage.SaveKeyUserName);
        string logTime = PropertiesHelper.Get<string>(RegisterPage.SaveKeyLogTime);

        public void RefreshData()
        {
            UserNameId = PropertiesHelper.Get<string>(RegisterPage.SaveKeyUserName);
            LogTime = PropertiesHelper.Get<string>(RegisterPage.SaveKeyLogTime);
        }

        void AccountOperationEvent(object obj)
        {        
            //Apphelper.HomeTabPage.Navigation.PushAsync(new AccountOperationPage());
        }

        async void LogOutEvent(object obj)
        {
            await Apphelper.Logout();
        }

        private void HelpEvent(object obj)
        {
            Apphelper.HomeTabPage.Navigation.PushAsync(new HelpPage());
        }

        private void AboutEvent(object obj)
        {
            Apphelper.HomeTabPage.Navigation.
                PushAsync(new AboutPage(new AboutPageViewModel()));
        }

        public MineViewViewModel()
        {
            AccountOperation = new Command(AccountOperationEvent);
            LogOut = new Command(LogOutEvent);
            Help = new Command(HelpEvent);
            About = new Command(AboutEvent);
        }

        public string UserNameId
        {
            get { return userNameId; }
            set { SetProperty(ref userNameId, value); }
        }

        public string LogTime
        {
            get { return logTime; }
            set { SetProperty(ref logTime, value); }
        }

        public Command AccountOperation { get; set; }
        public Command LogOut { get; set; }
        public Command Help { get; set; }
        public Command About { get; set; }


    }
}
