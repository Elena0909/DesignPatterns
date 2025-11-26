using ObserverPattern.Publishers;

namespace ObserverPattern.Subscribers;

public class TechnologyNewsSubscriber : INewsSubscriber
{
    private readonly TechnologyNewsPublisher _publisher;

    public TechnologyNewsSubscriber(TechnologyNewsPublisher publisher)
    {
        _publisher = publisher;
        _publisher.AddSubscribers(this);
    }
    public void Update()
    {
        decimal lastPrice = _publisher.GetLastRtxPrice();
        Console.WriteLine($"Tech Subscriber {GetHashCode()} update last price {lastPrice}");
    }
}
