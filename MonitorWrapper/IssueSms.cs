using System;

namespace MonitorWrapper
{
    class IssueSms
    {
        private IRaiseAlert _raiseAlert { get; set; }

        public IssueSms(IRaiseAlert raiseAlert)
        {
            this._raiseAlert = raiseAlert;
        }
    }
}
