

using FactoryPatterns.ConcreteStrategy;
using FactoryPatterns.Strategy;

namespace FactoryPatterns.Factory;

public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard card = new Titanium();
        // very complicate logic..
        return card;
    }
}
