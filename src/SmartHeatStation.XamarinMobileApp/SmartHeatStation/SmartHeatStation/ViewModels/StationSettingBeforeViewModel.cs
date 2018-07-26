using System.Threading.Tasks;
using System.Linq;

using SmartHeatStation.Models;
using SmartHeatStation.Helper;
using SmartHeatStation.Pages;
using SmartHeatStation.Sqlite.Models;

namespace SmartHeatStation.ViewModels
{
    public class StationSettingBeforeViewModel : ListViewModelBase<ItemMenu>
    {
        public StationSettingBeforeViewModel(string title) : base(title)
        {
            IsRefreshEnable = false;
        }

        public async override Task InitializeAsync()
        {
            if (IsInitialize == true)
                return;
            IsBusy = true;   
            await Task.Delay(2000); //让用户加钱进行优化
            IsInitialize = await Task.Run(async () => {
                var tableString = $"[{nameof(StationFixPara)}]";
                var queryString = $"select * from {tableString}";
                var items = App.Database.Query<StationFixPara>(queryString);
                var newItems = from item in items
                               orderby item.DisplaySort ascending 
                               select item;
                foreach (var item in newItems)
                {
                    await AddItemAsync(new ItemMenu()
                    {
                        Text = item.Name,
                        Id = item.ID.ToString()
                    });
                }
                return true;
            });
            IsBusy = false;
        }

        public async override void OnSelectItem(ItemMenu item)
        {
            if (item == null)
                return;
            var id = int.Parse(item.Id);
            var tableString = "[StationFixPara]";
            var queryString = $"select * from {tableString} where ID = ?";
            var itemPara = App.Database.
                Query<StationFixPara>(queryString,id).FirstOrDefault();
            await Apphelper.HomeTabPage.Navigation.
                    PushAsync(new StationSettingPage(
                        new StationSettingViewModel(item.Text,itemPara)));
        }

    }
}
