using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartHeatStation.Helper;
using SmartHeatStation.ViewModels;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StationSettingPage : ContentPage
    {
        private StationSettingViewModel ViewModel;

        public StationSettingPage(StationSettingViewModel stationSettingViewModel)
        {
            InitializeComponent();
            this.ViewModel = stationSettingViewModel;
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

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
