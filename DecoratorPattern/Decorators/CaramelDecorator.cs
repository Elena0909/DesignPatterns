using DecoratorPattern.Component;
using System.Text;

namespace DecoratorPattern.Decorators;

public class CaramelDecorator : BeverageDecorator
{
    public CaramelDecorator(IBeverage beverage) : base(beverage)
    {
    }

    public override decimal GetCost()
    {
        var cost = _beverage.GetCost() + 0.4m;
        return cost;
    }

    public override StringBuilder Description()
    {
        return _beverage.Description().Append($"+caramel");
    }
}
