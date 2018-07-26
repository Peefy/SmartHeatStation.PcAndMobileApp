using SmartHeatStation.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        SearchPageViewModel searchPageViewModel;

        public SearchPage(SearchPageViewModel searchPageViewModel)
        {
            InitializeComponent();
            this.searchPageViewModel = searchPageViewModel;
            this.BindingContext = this.searchPageViewModel;

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchPageViewModel.OnSearch(e.NewTextValue);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = false;
            await Task.Delay(200);
            entry.Focus();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = true;
        }

    }
}
