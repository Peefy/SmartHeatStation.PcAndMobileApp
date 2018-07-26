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
    public partial class CommunacationSettingPage : ContentPage
    {
        ViewModels.CommunacationPageViewModel viewModel;
        public CommunacationSettingPage(ViewModels.CommunacationPageViewModel pViewModel)
        {
            InitializeComponent();
            viewModel = pViewModel;
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
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
            Title = Helper.TimerHelper.GetUpLoadTime();
        }
    }
}
