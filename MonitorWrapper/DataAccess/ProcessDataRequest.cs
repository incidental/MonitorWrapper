using MonitorWrapper.RaiseAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWrapper.DataAccess
{
    class ProcessDataRequest : IProcessDataRequest
    {
        public IRaiseAlert _concreteRaiseAlert { get; set; }

        public IEnumerable<T> GetMonitorHistory<T>()
        {
            var history = string.Empty;
            throw new NotImplementedException();
        }

        public IMonitorRecord GetMonitorValues(int monitorId)
        {
            throw new NotImplementedException();
        }

        public bool IssueAlert(IRaiseAlert raiseAlert)
        {
            this._concreteRaiseAlert = raiseAlert;
            throw new NotImplementedException();
        }

        public bool RecordMonitorResult<T>(T monitorResult)
        {
            throw new NotImplementedException();
        }
    }
}
