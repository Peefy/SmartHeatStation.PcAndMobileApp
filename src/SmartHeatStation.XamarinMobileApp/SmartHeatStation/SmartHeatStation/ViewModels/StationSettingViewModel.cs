using SmartHeatStation.Models;
using SmartHeatStation.Sqlite.Models;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class StationSettingViewModel : ListViewModelBase<ItemStationDetail>
    {

        StationFixPara fixPara;

        public StationSettingViewModel(string title,StationFixPara para) : base(title)
        {
            IsRefreshEnable = false;
            OkToolBarCommand = new Command(OnOkToolBarClicked);
            fixPara = para;
        }

        public override async void OnRefresh(object obj)
        {
            IsBusy = true;
            await Task.Run(() =>
            {

            });
            IsBusy = false;
        }

        public override async Task InitializeAsync()
        {
            if (IsInitialize == true)
                return;
            IsBusy = true;
            //让用户加钱进行优化
            await Task.Delay(500);
            IsInitialize = await Task.Run(async () =>
            {
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "通信Ip",
                    ParaValue = fixPara.Ip,
                });
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "通信端口号",
                    ParaValue = fixPara.Port,
                });
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "地址",
                    ParaValue = fixPara.Addr,
                });
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "实供面积",
                    ParaValue = fixPara.ActArea,
                });
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "注册面积",
                    ParaValue = fixPara.RegieterArea,
                });
                await AddItemAsync(new ItemStationDetail()
                {
                    ParaName = "是否在用",
                    ParaValue = fixPara.IsUsed == "True" ? "是":"否",
                });
                return true;
            });
            IsBusy = false;
        }

        public override void OnSelectItem(ItemStationDetail item)
        {
            if (item == null)
                return;
        }

        public Command OkToolBarCommand;
        async void OnOkToolBarClicked(object obj)
        {
            
        }
    }
}
