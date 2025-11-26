using System.Data;

namespace AdapterPattern;

public class CloudLogSaver
{

    public void Save(DateTime loggedAt, string message)
    {
        Console.WriteLine($"Saving log to Cloud. {loggedAt} {message}");
    }

    public void SaveException(DateTime loggedAt, string message, string error)
    {
        Console.WriteLine($"Saving log to Cloud. {loggedAt} {message} {error}");
    }
}
