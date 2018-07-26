using System;

using System.ComponentModel;
using System.Runtime.CompilerServices;

using SQLite;

namespace SmartHeatStation.Sqlite.Models
{
    public class BaseSqliteModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        //AutoIncrement
        [PrimaryKey, Column("ID")]
        public int ID
        {
            get;
            set;
        }

        [Column("Name")]
        public string Name
        {
            get;
            set;
        }

    }
}
