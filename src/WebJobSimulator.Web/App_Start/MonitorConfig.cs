using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebJobSimulator.Common;

namespace WebJobSimulator.Web.App_Start
{
    public class MonitorConfig
    {
        public static void Configure(string path)
        {
            WebJobMonitorManager.Start(path);
        }
    }
}