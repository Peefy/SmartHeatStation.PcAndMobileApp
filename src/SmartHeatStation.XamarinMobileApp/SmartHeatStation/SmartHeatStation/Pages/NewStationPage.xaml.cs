using SmartHeatStation.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewStationPage : ContentPage
    {

        public Item Item { get; set; }
        public string TableViewTitle { get; set; } = "请添加一个新站";

        bool isAddNewStation;

        public NewStationPage()
        {
            InitializeComponent();

            Item = new Item
            {
                StationStatus = StationStatusEnum.Error,
                StationName = "新站站名",
                Description = "说明文字",
            };
            Title = "添加新站";
            isAddNewStation = true;
            BindingContext = this;
        }

        public NewStationPage(Item item)
        {
            InitializeComponent();
            Item = item;
            Title = "修改信息";
            isAddNewStation = false;
            BindingContext = this;         
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

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            if(isAddNewStation == true)
                MessagingCenter.Send(this,Utils.MessengerKeys.NewStation, Item);
            await Navigation.PopToRootAsync();
        }
    }
}
