using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHeatStation.Services
{
    class ApplicationService
    {
        public static void DoubleFinish()
        {
            DependencyService.Get<ICloseContext>().DoubleClickFinish();
        }
    }
}
