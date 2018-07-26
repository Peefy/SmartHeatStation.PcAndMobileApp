using SmartHeatStation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHeatStation.Helper
{
    class Apphelper
    {
        public const string Version = "1.0.0";
        public const string ApplicationName = "智慧换热站";
        async public static Task Logout()
        {
            var result = await HomeTabPage.DisplayAlert("系统消息", "确定要退出登陆吗?", "确定", "取消");
            if (result == true)
            {
                HomePage.IsPresented = false;
                PropertiesHelper.Set(RegisterPage.SaveKeyIsRegister, false);
                HomeTabPage.RepportView.SaveState(Application.Current.Properties);
                if (Application.Current.MainPage is HomePage)
                {
                    var homepage = Application.Current.MainPage as HomePage;
                    await homepage.Navigation.PushModalAsync(new RegisterPage());
                }
                else
                {
                    var homepage = Application.Current.MainPage as RegisterPage;
                    await homepage.Navigation.PopModalAsync();
                }
            }
        }

        public static HomeDetailPage HomeTabPage
        {
            get
            {
                //C# 7.0 模式匹配
                var page = Application.Current.MainPage;
                switch(page)
                {
                    case HomePage homePage:
                        return homePage.HomeTabPage;
                    case RegisterPage registerPage:   
                        return (registerPage.Navigation.ModalStack[0] as HomePage).HomeTabPage;
                    default:
                        throw new InvalidOperationException(nameof(page));
                }

            }
        }

        public static HomePage HomePage
        {
            get
            {
                if (Application.Current.MainPage is HomePage)
                {
                    var homepage = Application.Current.MainPage as HomePage;
                    return homepage;
                }
                else
                {
                    var homepage = Application.Current.MainPage.Navigation.ModalStack[0] as HomePage;
                    return homepage;
                }

            }
        }

    }
}
