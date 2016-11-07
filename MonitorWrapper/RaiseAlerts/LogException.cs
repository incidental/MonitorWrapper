using System;

namespace MonitorWrapper.RaiseAlerts
{
    class LogException
    {
        private IRaiseAlert _raiseAlert { get; set; }

        public LogException(IRaiseAlert raiseAlert)
        {
            this._raiseAlert = raiseAlert;
        }
    }
}
