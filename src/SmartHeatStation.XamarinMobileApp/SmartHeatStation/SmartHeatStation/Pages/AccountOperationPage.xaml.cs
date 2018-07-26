using AsNum.XFControls;
using AsNum.XFControlsEx;
using SmartHeatStation.Controls;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Threading.Tasks;
using System;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountOperationPage : ContentPage
    {
        public AccountOperationPage()
        {
            InitializeComponent();
            this.BindingContext = this;

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


        public IEnumerable<FlipItem> FlipSource { get; }
            = new List<FlipItem>() {
                new FlipItem() {
                    Desc = "",
                    Img = "background.png"
                },
                new FlipItem() {
                    Desc = "",
                    Img = "menu_bg.png"
                },
                                new FlipItem() {
                    Desc = "",
                    Img = "my.png"
                }
            };


       
    }
}
