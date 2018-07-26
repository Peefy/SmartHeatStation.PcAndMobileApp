
using SmartHeatStation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;
        protected readonly IConnectServer ConnectService;

        public ViewModelBase()
        {
            DialogService = DependencyService.Get<DiaLogService>();
            ConnectService = DependencyService.Get<Services.IConnectServer>();
            NavigationService = DependencyService.Get<NavigationService>();
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public virtual void SaveState(IDictionary<string, object> dictionary)
        {

        }

        public virtual void RestoreState(IDictionary<string, object> dictionary)
        {

        }

        public T GetDictionaryEntry<T>(IDictionary<string, object> dictionary,
            string key, T defaultValue)
        {
            if (dictionary.ContainsKey(key))
                return (T)dictionary[key];
            return defaultValue;
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        bool isInitialize = false;
        public bool IsInitialize
        {
            get { return isInitialize; }
            set { SetProperty(ref isInitialize, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
