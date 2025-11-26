namespace AdapterPattern;

public class CloudLogSaverAdapter : ILogSaver
{
    private readonly CloudLogSaver _cloudLogSaver = new CloudLogSaver();
    public void SaveError(Log log)
    {
        _cloudLogSaver.SaveException(log.LoggedAt, log.Message, log.ErrorStackTrace);
    }

    public void SaveLog(Log log)
    {
        _cloudLogSaver.Save(log.LoggedAt, log.Message);
    }
}
