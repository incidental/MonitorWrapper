namespace MonitorWrapper.DataAccess
{
    interface IMonitorRecord
    {
        int MonitorId { get; set; }
        string MonitorName { get; set; }
        string MonitorType { get; set; }
        int HistoryCount { get; set; }
        string Host { get; set; }
        string Directory { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
        bool Active { get; set; }
    }
}
