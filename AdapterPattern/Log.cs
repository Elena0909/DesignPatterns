namespace AdapterPattern;

public class Log
{
    public DateTime LoggedAt {  get; set; }

    public string Message { get; set; }

    public string ErrorStackTrace { get; set; }

    public Log(string message, string errorStackTrace = "")
    {
        LoggedAt = DateTime.Now;
        Message = message;
        ErrorStackTrace = errorStackTrace;
    }

}
