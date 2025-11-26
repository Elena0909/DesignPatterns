using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy;

internal class BusTravelStrategy : ITravelStrategy
{
    public void GoToAirport()
    {
        Console.WriteLine("The traveler chose to go to the airport by bus.");
    }
}
