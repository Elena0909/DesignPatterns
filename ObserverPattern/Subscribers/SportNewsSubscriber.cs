using ObserverPattern.Publishers;

namespace ObserverPattern.Subscribers;

public class SportNewsSubscriber : INewsSubscriber
{
    private readonly SportNewsPublisher _publisher;

    public SportNewsSubscriber(SportNewsPublisher publisher)
    {
        _publisher = publisher;
        _publisher.AddSubscribers(this);
    }
    public void Update()
    {
        string info = _publisher.GetLastSportInfo();
        Console.WriteLine($"Sport Subscriber {GetHashCode()} receive info: {info}");
    }
}
