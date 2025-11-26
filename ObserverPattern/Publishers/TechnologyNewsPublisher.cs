namespace ObserverPattern.Publishers;

public class TechnologyNewsPublisher : NewsPublisher
{
    private decimal _rtxPrice;

    public void SetLastRtxPrice(decimal price)
    {
        _rtxPrice = price;
        NotifySubscribers();
    }

    public decimal GetLastRtxPrice()
    {
        return _rtxPrice;
    }
}
