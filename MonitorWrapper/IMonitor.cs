using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWrapper
{
    interface IMonitor : IProcessRequest, IRaiseAlert
    {
        void InitiateCheck();
    }
}
