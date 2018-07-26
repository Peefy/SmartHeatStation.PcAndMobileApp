using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DuGu.XFLib.Controls;
using System.Threading.Tasks;

namespace SmartHeatStation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeDetailPage : ContentPage
    {

        readonly Color TabBarColorFilter = Color.FromHex("#2196F3");

        List<TabViewChildren> Views;

        public ViewModels.HomeViewListViewModel HomeViewModel { get; set; }
        public ViewModels.RepportViewViewModel RepportViewModel { get; set; }
        public ViewModels.MineViewViewModel MineViewModel { get; set; }

        public Views.HomeView HomeView { get; set; }
        public Views.RepportView RepportView { get; set; }
        public Views.MineView MineView { get; set; }

        public HomeDetailPage()
        {
            InitializeComponent();

            HomeViewModel = new ViewModels.HomeViewListViewModel("");
            HomeView = new Views.HomeView(HomeViewModel);

            RepportViewModel = new ViewModels.RepportViewViewModel();
            RepportView = new Views.RepportView(RepportViewModel);

            MineViewModel = new ViewModels.MineViewViewModel();
            MineView = new Views.MineView(MineViewModel);

            #region ThreeViews
            Views = new List<TabViewChildren>()
            {
                new TabViewChildren()
                {
                    Text = "主页",
                    UnSelectImageSource = "tab0.png",
                    SelectedTextColor = TabBarColorFilter,
                    ImageColorFilter = TabBarColorFilter,
                    View = HomeView,
                },
                new TabViewChildren()
                {
                    Text = "记录",
                    UnSelectImageSource = "tab1.png",
                    SelectedTextColor = TabBarColorFilter,
                    ImageColorFilter = TabBarColorFilter,
                    View = RepportView,
                },
                new TabViewChildren()
                {
                    Text = "我的",
                    UnSelectImageSource = "tab2.png",
                    SelectedTextColor = TabBarColorFilter,
                    ImageColorFilter = TabBarColorFilter,
                    View = MineView,
                }
            };
            tabView.AddChildrenViews(Views);
            #endregion

            tabView.SelectedChanged += TabView_SelectedChanged;

          
        }

        private void TabView_SelectedChanged(object sender, TabViewChangedEventArgs e)
        {
            ToolbarItems.Clear();
            if (e.Index == 0)
            {
                var item = new ToolbarItem() { Text = "搜索" };
                item.Clicked += ToolbarItem_Clicked;
                ToolbarItems.Add(item);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (HomeViewModel?.Items.Count == 0)
                HomeViewModel?.LoadItemsCommand.Execute(null);
        }

        protected override bool OnBackButtonPressed()
        {
            this.RepportView?.SaveState(Application.Current.Properties);
            this.HomeViewModel?.SaveState(Application.Current.Properties);
            Services.ApplicationService.DoubleFinish();
            return true;
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage(
                new ViewModels.SearchPageViewModel("",HomeViewModel)));
        }

        private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            int i = 0;
            await Task.Run(() =>
            {
                foreach (var stationCode in HomeViewModel.StationCodes)
                {
                    App.Database.AddItem(new Sqlite.Models.StationFixPara()
                    {
                        ID = i,
                        Name = stationCode.Dictionary["station"],
                        ActArea = stationCode.Dictionary["actarea"],
                        Addr = stationCode.Dictionary["addr"],
                        DisplaySort = stationCode.Dictionary["dispsort"],
                        FC1_Visible = stationCode.Dictionary["fc1visible"],
                        FC2_Visible = stationCode.Dictionary["fc2visible"],
                        FC3_Visible = stationCode.Dictionary["fc3visible"],
                        FC4_Visible = stationCode.Dictionary["fc4visible"],
                        FC5_Visible = stationCode.Dictionary["fc5visible"],
                        FC6_Visible = stationCode.Dictionary["fc6visible"],
                        FC7_Visible = stationCode.Dictionary["fc7visible"],
                        FC8_Visible = stationCode.Dictionary["fc8visible"],
                        FC9_Visible = stationCode.Dictionary["fc9visible"],
                        FC10_Visible = stationCode.Dictionary["fc10visible"],
                        RegieterArea = stationCode.Dictionary["registearea"],
                        Flow1_Visible = stationCode.Dictionary["flow1visible"],
                        Flow2_Visible = stationCode.Dictionary["flow2visible"],
                        Flow3_Visible = stationCode.Dictionary["flow3visible"],
                        Flow4_Visible = stationCode.Dictionary["flow4visible"],
                        Ip = stationCode.Dictionary["ip"],
                        Port = stationCode.Dictionary["port"],
                        IsUsed = stationCode.Dictionary["used"],
                        LP1_Visible = stationCode.Dictionary["lp1visible"],
                        LP2_Visible = stationCode.Dictionary["lp2visible"],
                        LP3_Visible = stationCode.Dictionary["lp3visible"],
                        LP4_Visible = stationCode.Dictionary["lp4visible"],

                        LT1_Visible = stationCode.Dictionary["lt1visible"],
                        LT2_Visible = stationCode.Dictionary["lt2visible"],
                        LT3_Visible = stationCode.Dictionary["lt3visible"],
                        LT4_Visible = stationCode.Dictionary["lt4visible"],

                        SP1_Visible = stationCode.Dictionary["sp1visible"],
                        SP2_Visible = stationCode.Dictionary["sp2visible"],
                        SP3_Visible = stationCode.Dictionary["sp3visible"],
                        SP4_Visible = stationCode.Dictionary["sp4visible"],

                        ST1_Visible = stationCode.Dictionary["lt1visible"],
                        ST2_Visible = stationCode.Dictionary["lt2visible"],
                        ST3_Visible = stationCode.Dictionary["lt3visible"],
                        ST4_Visible = stationCode.Dictionary["lt4visible"],

                        WaterboxDown = stationCode.Dictionary["waterbox_down"],
                        WaterboxHeight = stationCode.Dictionary["waterboxheight"],
                        WaterboxStop = stationCode.Dictionary["waterbox_stop"],
                        WaterboxSupply = stationCode.Dictionary["waterbox_supply"],
                        WaterboxUp = stationCode.Dictionary["waterbox_up"],
                        Waterbox_VisiBle = stationCode.Dictionary["actarea"],
                    });
                    ++i;
                }

            });
        }

    }
}
