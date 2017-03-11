using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WebJobSimulator.Common
{
    public class WebJobMonitor
    {
        private readonly Timer _timer = new Timer();
        private readonly object _locked = new object();

        public void Start(int interval, ElapsedEventHandler handler)
        {
            lock (_locked)
            {
                _timer.Interval = interval;
                _timer.Elapsed += handler;
                _timer.AutoReset = true;
                _timer.Enabled = true;
            }
        }
    }
}
