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
    public partial class StationParaInfoPage : ContentPage
    {
        public ViewModels.StationParaInfoViewModel viewModel;
        public StationParaInfoPage(ViewModels.StationParaInfoViewModel pViewModel)
        {
            InitializeComponent();
            viewModel = pViewModel;
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = false;
            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Helper.Apphelper.HomePage.IsGestureEnabled = true;
        }

    }
}
