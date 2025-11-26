using System.Text;

namespace DecoratorPattern.Component;

public interface IBeverage
{
    public decimal GetCost();

    public StringBuilder Description();
}
