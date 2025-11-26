namespace AdapterPattern;

internal class DatabaseLogSaver : ILogSaver 
{
    public void SaveLog(Log log)
    {
        Console.WriteLine($"Saving log to DB {log.LoggedAt} {log.Message}");
    }

    public void SaveError(Log log)
    {
        Console.WriteLine($"Saving log to DB {log.LoggedAt} {log.Message} {log.ErrorStackTrace}");
    }
}
