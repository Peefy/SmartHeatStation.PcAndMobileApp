using SmartHeatStation.Models;
using System;

using Xamarin.Forms;

namespace SmartHeatStation.Views
{
    public partial class HomeView : ContentView
    {

        Pages.HomeDetailPage homePage => Parent.Parent.Parent as Pages.HomeDetailPage;
        public ListView ItemListView => itemsListView;
        public StackLayout ViewsStack => viewsStack;
        public ViewModels.HomeViewViewModel ViewModel { get; set; }
        public ViewModels.HomeViewListViewModel ListViewModel { get; set; }

        public HomeView(ViewModels.HomeViewViewModel pViewModel)
        {
            InitializeComponent();
            ViewModel = pViewModel;
            this.BindingContext = ViewModel;
        }

        public HomeView(ViewModels.HomeViewListViewModel pViewModel)
        {
            InitializeComponent();
            ListViewModel = pViewModel;
            this.BindingContext = ListViewModel;
        }

        private void OnChange(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var item = menuItem.CommandParameter as Item;
            ViewModel.ChangeItemCommad.Execute(item);
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var item = menuItem.CommandParameter as Item;
            ViewModel.DeleteItemCommad.Execute(item);
        }

    }
}
