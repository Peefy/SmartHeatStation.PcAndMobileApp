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
    public partial class HomeMasterPage : ContentPage
    {
        public ViewModels.MasterPageViewModel viewModel;
        public HomeMasterPage(ViewModels.MasterPageViewModel pViewModel)
        {
            InitializeComponent();
            viewModel = pViewModel;
            this.BindingContext = viewModel;
            Title = "≡";
        }

        public HomeMasterPage()
        {
            InitializeComponent();
            Title = "“≡";
        }

    }
}
