using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWrapper
{
    class Monitor : IMonitor
    {
        public IProcessRequest _processRequest { get; set; }
        public IRaiseAlert _raiseAlert { get; set; }

        public Monitor()
        {
            
        }

        public void InitiateCheck()
        {
            throw new NotImplementedException();
        }
    }
}
