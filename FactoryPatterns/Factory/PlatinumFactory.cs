using FactoryPatterns.ConcreteStrategy;
using FactoryPatterns.Strategy;

namespace FactoryPatterns.Factory;

public class PlatinumFactory :CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard card = new Platinum();
        return card;
    }
}
