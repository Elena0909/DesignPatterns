using ObserverPattern.Subscribers;

namespace ObserverPattern.Publishers;

public abstract class NewsPublisher
{
    private List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();
    public void AddSubscribers(INewsSubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscribers(INewsSubscriber subscriber) 
    { 
        _subscribers.Remove(subscriber);
    }

    public void NotifySubscribers() 
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update();
        }
    }
}
