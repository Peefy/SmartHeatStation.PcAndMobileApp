using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHeatStation.Models;
using SmartHeatStation.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class SearchPageViewModel : ListViewModelBase<ItemMenu>
    {

        HomeViewListViewModel mHomeViewModel;

        public ICommand SearchCommad => new Command<string>(OnSearch);

        public SearchPageViewModel(string title,HomeViewListViewModel pHomeViewModel) : base(title)
        {
            Title = "搜索";
            mHomeViewModel = pHomeViewModel;

            IsRefreshEnable = false;
        }

        public async override Task InitializeAsync()
        {
            await Task.Run(async () =>
            {
                
            });
            IsInitialize = true;
        }

        public async override void OnSelectItem(ItemMenu item)
        {
            if (item == null)
                return;
            Item homeItem = await mHomeViewModel.GetItemAsync(item.Id);
            mHomeViewModel.OnSelectItem(homeItem);
        }

        public async void OnSearch(string obj)
        {
            Items.Clear();
            if (obj == "")
                return;
            foreach(var item in mHomeViewModel.Items)
            {
                if(item.StationName.Contains(obj))
                {
                    await AddItemAsync(new ItemMenu()
                    {
                        Text = item.StationName,
                        Id = item.Id                     
                    });
                }
            }

        }

    }
}
