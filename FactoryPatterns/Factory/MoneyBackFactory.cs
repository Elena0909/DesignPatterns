

using FactoryPatterns.ConcreteStrategy;
using FactoryPatterns.Strategy;

namespace FactoryPatterns.Factory;

public class MoneyBackFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard card = new MoneyBack();
        return card;
    }
}
