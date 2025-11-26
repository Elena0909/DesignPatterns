using StrategyPattern.Strategy;
using StrategyPattern.ConcreteStrategy;

namespace StrategyPattern.Context;

public class TravelContext
{
    private ITravelStrategy travelStrategy = new CarTravelStrategy();

    public void SetTravelStrategy(ITravelStrategy travelStrategy)
    {
        this.travelStrategy = travelStrategy;
    }

    public void GoToAirport()
    {
        travelStrategy.GoToAirport();
    }
}
