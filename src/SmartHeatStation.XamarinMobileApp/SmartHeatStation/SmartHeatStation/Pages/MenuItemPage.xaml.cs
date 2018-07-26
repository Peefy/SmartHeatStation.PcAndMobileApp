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
    public partial class MenuItemPage : ContentPage
    {
        public MenuItemPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Apphelper.HomePage.IsGestureEnabled = true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Apphelper.HomePage.IsGestureEnabled = false;
        }

    }
}
