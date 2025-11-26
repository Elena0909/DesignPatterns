using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy;

public class CarTravelStrategy : ITravelStrategy
{
    public void GoToAirport()
    {
        Console.WriteLine("The traveler chose to go to the airport by car.");
    }
}
