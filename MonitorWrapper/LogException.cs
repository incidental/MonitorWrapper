using System;

namespace MonitorWrapper
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
