using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {

        string version;
        string company = "自动化研究所";
        string companyEnglish = "Boost600";
        string copyright;
        /// <summary>
        /// 构造函数
        /// </summary>
        public AboutPageViewModel()
        {
            Title = "关于";
            copyright = company + "\r\nCopyright © 2017-2017 " + companyEnglish +
                "\r\nAll Rights Reserved";
            version = $"{Helper.Apphelper.ApplicationName} {Helper.Apphelper.Version}";
        }
        /// <summary>
        /// 软件版本
        /// </summary>
        public string Version
        {
            get { return version; }
            set { SetProperty(ref version, value); }
        }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string Company
        {
            get { return company; }
            set { SetProperty(ref company, value); }
        }
       
        public string Copyright
        {
            get { return copyright; }
            set { SetProperty(ref copyright, value); }
        }

    }
}
