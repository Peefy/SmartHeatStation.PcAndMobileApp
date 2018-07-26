
using System.ComponentModel;

namespace SmartHeatStationService.Sqlite
{
    public class BaseSqliteModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }

        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

    }
}
