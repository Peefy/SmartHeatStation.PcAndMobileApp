using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagaSettingPage : ContentPage
    {
        public MessagaSettingPage()
        {
            InitializeComponent();
            Title = "消息设置";       
            this.BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Helper.Apphelper.HomePage.HomeMenupage.viewModel.ClearData.Execute(null);
        }
    }
}
