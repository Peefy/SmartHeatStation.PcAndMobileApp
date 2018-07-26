using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHeatStation.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.Services.DetailDataStore))]
namespace SmartHeatStation.Services
{
    class DetailDataStore : IDataStore<Models.ItemStationDetail>
    {
        bool isInitialized;
        List<Models.ItemStationDetail> items;

        string[] paraNames = 
        {
            "一网参数",
            "二网高区参数",
            "二网中区参数",
            "二网低区参数",

            "水箱1参数",
            "水箱2参数",
            "水箱进水阀参数",
            "总调节阀参数",

            "热量流量表参数",
            "泵0参数",
            "泵1参数",
            "泵2参数",
            "泵3参数",
            "泵4参数",
            "泵5参数",
            "泵6参数",
            "泵7参数",
            "泵8参数",
            "泵9参数",
        };

        public async Task<bool> AddItemAsync(Models.ItemStationDetail item)
        {
            await InitializeAsync();

            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Models.ItemStationDetail item)
        {
            await InitializeAsync();

            var _item = items.Where((ItemStationDetail arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(ItemStationDetail item)
        {
            await InitializeAsync();

            var _item = items.Where((ItemStationDetail arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<ItemStationDetail> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemStationDetail>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeAsync();

            return await Task.FromResult(items);
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }


        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

        public async Task InitializeAsync()
        {
            if (isInitialized)
                return;

            items = new List<ItemStationDetail>();
            var _items = new List<ItemStationDetail>();
            foreach(var str in paraNames)
            {
                _items.Add(new ItemStationDetail
                {
                    Id = str,
                    ParaName = str,
                    ParaValue = "正在获取..."
                });
            }
            
            foreach (ItemStationDetail item in _items)
            {
                items.Add(item);
            }

            isInitialized = true;
        }
    }
}
