
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public static string SaveKeyIsRegister { get; set; } = "isRegister";
        public static string SaveKeyUserName { get; set; } = "userName";
        public static string SaveKeyLogTime { get; set; } = "logTime";

        public RegisterPage()
        {
            InitializeComponent();
            Title = "大连金州智慧换热站";
            entryUserName.Text = Helper.PropertiesHelper.Get<string>(SaveKeyUserName);
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            bool isLog = false;
            //JudgeIsLoggingTrue(entryUserName.Text, entryPassword.Text);
            if (entryUserName.Text == "自动化研究所" && entryPassword.Text == "boost600")
            {
                isLog = true;
            }
            else if (entryUserName.Text == "DuGu" && entryPassword.Text == "123456")
            {
                isLog = true;
            }
            else if (entryUserName.Text == "DuGuDiaoLing" && entryPassword.Text == "123456")
            {
                isLog = true;
            }

            if (isLog == true)
            {
                button.Text = "正在登陆，请稍等....";
                button.IsEnabled = false;
                entryPassword.IsEnabled = false;
                entryUserName.IsEnabled = false;
                //UserDialogs.Instance.ShowLoading("正在登陆", MaskType.Gradient);
                await GotoHomeTabPageAsync();
            }
            else
            {
                await DisplayAlert("消息", "账号或者密码错误", "知道了");
            }
        }

        private bool JudgeIsLoggingTrue(string user, string pwd)
        {
            if (user == "自动化研究所" && pwd == "boost600")
            {
                return true;
            }
            else if (user == "DuGu" && pwd == "123456")
            {
                return true;
            }
            else if (user == "DuGuDiaoLing" && pwd == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        async Task GotoHomeTabPageAsync()
        {
            
            Application.Current.Properties[SaveKeyLogTime] = DateTime.Now.ToString();
            Application.Current.Properties[SaveKeyUserName] = entryUserName.Text;
            await Task.Delay(200);
            if (Application.Current.MainPage is HomePage)
            {
                var homepage = Application.Current.MainPage as HomePage;
                Application.Current.Properties[SaveKeyIsRegister] = true;
                homepage.HomeTabPage.MineViewModel.RefreshData();
                await homepage.Navigation.PopModalAsync();
            }
            else
            {

                var homepage = new HomePage();
                Application.Current.Properties[SaveKeyIsRegister] = true;
                await Navigation.PushModalAsync(homepage);
            }
            logButton.Text = "登 陆";
            logButton.IsEnabled = true;
            entryPassword.IsEnabled = true;
            entryPassword.Text = "";
            entryUserName.IsEnabled = true;
        }

        protected override bool OnBackButtonPressed()
        {
            Services.ApplicationService.DoubleFinish();
            return true;
        }

    }
}
