using SmartHeatStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.Services.MockDataStore))]
namespace SmartHeatStation.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        bool isInitialized;
        List<Item> items;

        public async Task<bool> AddItemAsync(Item item)
        {
            await InitializeAsync();

            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            await InitializeAsync();

            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Item item)
        {
            await InitializeAsync();

            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            isInitialized = !forceRefresh;
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

            items = new List<Item>();
            var _items = new List<Item>
            {
                new Item { Id = "0", StationName = "阿尔滨站",
                    StationStatus =StationStatusEnum.Unkown
                    ,Description="说明：\r\n"},
                new Item { Id = "1", StationName = "金渤海景站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "2" ,StationName = "南山站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "3", StationName = "金山站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "4", StationName = "政府站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "5", StationName = "龙王站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "6", StationName = "自来水站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "7", StationName = "南棉站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "8", StationName = "盐场站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "9", StationName = "金海国际站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "10", StationName = "北京郡站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "11", StationName = "光明西站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "12", StationName = "金海明珠站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "13", StationName = "金连领地站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "14", StationName = "金山名苑站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "15", StationName = "欧美亚站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "16", StationName = "铁路站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n高低中区，六循环三补水"},
                new Item { Id = "17", StationName = "五一站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "18", StationName = "于家洼站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = "19", StationName = "环保站",
                    StationStatus=StationStatusEnum.Unkown,
                    Description ="说明：\r\n"},
                new Item { Id = Guid.NewGuid().ToString(), IsLast = true }

            };

            foreach (Item item in _items)
            {
                items.Add(item);
            }

            isInitialized = true;
        }
    }
}
