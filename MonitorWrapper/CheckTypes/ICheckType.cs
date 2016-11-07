namespace MonitorWrapper.CheckTypes
{
    interface ICheckType
    {
        bool InitiateCheck();
        bool ProcessResult();
    }
}
