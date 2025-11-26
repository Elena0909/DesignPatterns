namespace ObserverPattern.Publishers;

public class SportNewsPublisher : NewsPublisher
{
    private string _lastSportInfo = string.Empty;

    public void SetLastSportInfo(string info)
    {
        _lastSportInfo = info;
        NotifySubscribers();
    }

    public string GetLastSportInfo()
    {
        return _lastSportInfo;
    }
}
