using SmartHeatStation.Helper;
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
    public partial class StationSettingBeforePage : ContentPage
    {
        ViewModels.StationSettingBeforeViewModel ViewModel;
        public StationSettingBeforePage(ViewModels.StationSettingBeforeViewModel pViewModel)
        {
            InitializeComponent();
            ViewModel = pViewModel;
            this.BindingContext = ViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Apphelper.HomePage.IsGestureEnabled = false;
            await ViewModel.InitializeAsync();

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Apphelper.HomePage.IsGestureEnabled = true;
        }

    }
}
