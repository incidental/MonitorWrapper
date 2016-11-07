using MonitorWrapper.CheckTypes;
using MonitorWrapper.DataAccess;
using MonitorWrapper.RaiseAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWrapper
{
    class Monitor : IMonitor
    {
        public IProcessDataRequest _processRequest { get; set; }
        public IRaiseAlert _raiseAlert { get; set; }
        public ICheckType _checkType { get; set; }

        public Monitor()
        {
            
        }

        public void InitiateCheck()
        {
            throw new NotImplementedException();
        }
    }
}
