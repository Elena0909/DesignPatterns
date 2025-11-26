namespace AdapterPattern;

public interface ILogSaver
{
    public void SaveLog(Log log);

    public void SaveError(Log log);
}
