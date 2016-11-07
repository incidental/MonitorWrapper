using System.Collections.Generic;

namespace MonitorWrapper.DataAccess
{
    interface IProcessDataRequest
    {
        bool RecordMonitorResult<T>(T monitorResult);
        IMonitorRecord GetMonitorValues(int monitorId);
        IEnumerable<T> GetMonitorHistory<T>();
    }
}
