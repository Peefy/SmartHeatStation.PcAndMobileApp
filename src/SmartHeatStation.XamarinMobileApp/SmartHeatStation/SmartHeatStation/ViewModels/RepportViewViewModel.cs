using SmartHeatStation.Models;

namespace SmartHeatStation.ViewModels
{
    public class RepportViewViewModel : ViewModelBase
    {
        string repportText = "Location: 大连金州";
        public string RepportText
        {
            get { return repportText; }
            set { SetProperty(ref repportText, value); }
        }

        public ObservableCollection<string> Items { get; set; }

        public RepportViewViewModel()
        {
            Items = new ObservableCollection<string>();
        }

    }
}
