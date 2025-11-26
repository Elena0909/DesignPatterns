using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy;

internal class SubwayTravelStrategy : ITravelStrategy
{
    public void GoToAirport()
    {
        Console.WriteLine("The traveler chose to go to the airport by subway.");
    }
}
