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
    public partial class StationDetailPage : ContentPage
    {
        ViewModels.StationDetailViewModel viewModel;

        public StationDetailPage(ViewModels.StationDetailViewModel viewmodel)
        {
            InitializeComponent();
            viewModel = viewmodel;
            this.BindingContext = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = false;
            if (viewModel.Items.Count == 0)
                 await viewModel.InitializeAsync();

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = true;
        }

    }
}
