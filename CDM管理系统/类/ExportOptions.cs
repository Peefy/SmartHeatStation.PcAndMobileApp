using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    public class ExportOptions
    {
        public string[] TableString =
        {
            "序号",
            "标定流量", 
            "标准表脉冲计数", 
            "标准表累积量", 
            "工作表脉冲计数", 
            "工作表累积量", 
            "误差（％）", 
            "仪表系数", 
        };
    }
}
