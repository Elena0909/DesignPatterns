using DecoratorPattern.Component;
using System.Text;

namespace DecoratorPattern.Decorators;

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public abstract decimal GetCost();

    public abstract StringBuilder Description();
}
