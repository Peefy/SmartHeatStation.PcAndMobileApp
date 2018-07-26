using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeatStation.Services
{
    public interface IDownLoad
    {
      Task<string> DownLoadString(string url);
    }
}
