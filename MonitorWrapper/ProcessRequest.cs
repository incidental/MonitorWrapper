using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorWrapper
{
    class ProcessRequest : IProcessRequest
    {
        public IRaiseAlert _concreteRaiseAlert { get; set; }

        public IEnumerable<T> GetHistory<T>()
        {
            throw new NotImplementedException();
        }

        public bool IssueAlert(IRaiseAlert raiseAlert)
        {
            this._concreteRaiseAlert = raiseAlert;
            throw new NotImplementedException();
        }

        public bool RecordResult<T>(T monitorResult)
        {
            throw new NotImplementedException();
        }
    }
}
