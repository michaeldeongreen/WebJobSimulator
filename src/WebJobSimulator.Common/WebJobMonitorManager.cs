using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WebJobSimulator.Common.Interfaces;

namespace WebJobSimulator.Common
{
    public class WebJobMonitorManager
    {
        private static readonly WebJobMonitor _blogMonitor = new WebJobMonitor();
        private static IConfigurationManagerWrapper _configurationManagerWrapper = new ConfigurationManagerWrapper(ConfigurationManager.AppSettings);
        private static string _path = string.Empty;

        public static void Start(string path)
        {
            if (_configurationManagerWrapper.Convert("WebJobMonitorEnabled").ToABool())
            {
                _path = path;
                int monitorInterval = _configurationManagerWrapper.Convert("WebJobMonitorInterval").ToAInt();
                _blogMonitor.Start(monitorInterval, HandleBlogMonitorElapsedEvent);
            }
        }

        public static void HandleBlogMonitorElapsedEvent(Object source, ElapsedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(string.Format(@"{0}\simulatorlogger.txt",_path), true))
            {
                sw.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
