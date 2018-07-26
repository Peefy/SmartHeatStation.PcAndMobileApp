using SmartHeatStation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeSettingPage : ContentPage
    {
        TimeSettingViewModel viewModel;

        public TimeSettingPage(TimeSettingViewModel timeSettingViewModel)
        {
            InitializeComponent();
            this.viewModel = timeSettingViewModel;
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

        private void switchFindOhterTime_Toggled(object sender, ToggledEventArgs e)
        {
            Helper.TimerHelper.IsCheckNotNow = e.Value;
        }
    }
}
