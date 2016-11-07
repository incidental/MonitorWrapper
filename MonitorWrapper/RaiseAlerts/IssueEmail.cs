using System;

namespace MonitorWrapper.RaiseAlerts
{
    class IssueEmail
    {
        private IRaiseAlert _raiseAlert { get; set; }

        public IssueEmail(IRaiseAlert raiseAlert)
        {
            this._raiseAlert = raiseAlert;
        }
    }
}
