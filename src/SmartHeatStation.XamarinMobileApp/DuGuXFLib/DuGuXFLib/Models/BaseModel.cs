
using System.ComponentModel;

namespace DuGu.XFLib.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }

    }
}
