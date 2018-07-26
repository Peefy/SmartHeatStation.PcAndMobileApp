using SmartHeatStation.Helper;
using SmartHeatStation.Models;
using SmartHeatStation.Models.ParaInfo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartHeatStation.ViewModels
{
    public class ExceptionViewModel : ListViewModelBase<ItemMenu>
    {

        List<StationCode> StationCodes => Apphelper.HomeTabPage.HomeView.ListViewModel.StationCodes;
        List<GatherData> GatherDatas => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherDatas;
        List<GatherError> GatherErrors => Apphelper.HomeTabPage.HomeView.ListViewModel.GatherErrors;

        public ExceptionViewModel(string title) : base(title)
        {
            
        }

        public async override void OnRefresh(object obj)
        {
            IsBusy = true;
            await Task.Run(() =>
            {

            });
            IsBusy = false;
        }

        public override async Task InitializeAsync()
        {
            await Task.Delay(100);
            await Task.Run(async ()=>
            {
                int count = StationCodes.Count;
                for(int i = 0;i< count ;++i)
                {

                    if(GatherDatas[i].Dictionary["alarmsign"] == "True" ||
                        GatherDatas[i].Dictionary["errsign"] == "True")
                    {
                        await AddItemAsync(new ItemMenu()
                        {
                            Id = StationCodes[i].Dictionary["station"],
                            Text = "报警原因:" + GatherDatas[i].AlarmReason + "\r\n" +
                                   "故障原因:" + GatherErrors[i].ErrorReason
                        });
                    }

                }
            });
            if (Items.Count == 0)
                IsInitialize = true;
        }
    }
}
