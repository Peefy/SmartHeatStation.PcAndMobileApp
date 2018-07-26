using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHeatStation.Models.ParaInfo;
using SmartHeatStation.ViewModels;
using SmartHeatStation.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExceptionPage : ContentPage
    {
        ExceptionViewModel viewModel;
        List<Station> Stations => Apphelper.HomeTabPage.HomeView.ViewModel.Stations;

        public ExceptionPage(ExceptionViewModel exceptionViewModel)
        {
            InitializeComponent();
            viewModel = exceptionViewModel;
            this.BindingContext = viewModel;
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = false;
            await viewModel.InitializeAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = true;
        }

    }
}
