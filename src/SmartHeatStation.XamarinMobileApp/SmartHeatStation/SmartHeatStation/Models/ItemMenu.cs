using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeatStation.Models
{
    public class ItemMenu : BaseDataObject
    {
        string imageSource = string.Empty;
        public string ImageSource
        {
            get { return imageSource; }
            set { SetProperty(ref imageSource, value); }
        }

        string text = string.Empty;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
