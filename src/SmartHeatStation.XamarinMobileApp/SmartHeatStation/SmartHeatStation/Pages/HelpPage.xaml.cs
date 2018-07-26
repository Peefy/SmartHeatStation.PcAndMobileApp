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
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();

            //var x = App.Database.Query<Sqlite.Models.StationFixPara>("select * from [StationFixPara] where FC8_Visible = ? ", true);
            var count = App.Database.GetItems<Sqlite.Models.StationFixPara>().Count();
            label.Text = App.Database.DatabasePath + "  " + count + " " +
                App.Database.GetSize() + " "; //+ x?.Count;
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
