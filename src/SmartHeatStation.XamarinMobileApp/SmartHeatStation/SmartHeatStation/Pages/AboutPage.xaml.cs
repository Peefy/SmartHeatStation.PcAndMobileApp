
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public ViewModels.AboutPageViewModel viewModel;
        public AboutPage(ViewModels.AboutPageViewModel pViewModel)
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


    }
}
