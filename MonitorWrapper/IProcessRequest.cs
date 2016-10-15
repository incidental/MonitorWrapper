using System.Collections.Generic;

namespace MonitorWrapper
{
    interface IProcessRequest
    {
        bool RecordResult<T>(T monitorResult);
        IEnumerable<T> GetHistory<T>();
    }
}
