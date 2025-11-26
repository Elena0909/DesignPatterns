using FactoryPatterns.Strategy;

namespace FactoryPatterns.Factory;

public abstract class CreditCardFactory
{
    protected abstract ICreditCard MakeProduct();

    public ICreditCard CreateProduct()
    {
        ICreditCard creditCard = MakeProduct();
        return creditCard;
    }
}
