using FactoryPatterns.Strategy;
using FactoryPatterns.ConcreteStrategy;

namespace FactoryPatterns.Factory;

public class MyFactory
{
    private static readonly Dictionary<string, Func<ICreditCard>> _creators = new Dictionary<string, Func<ICreditCard>>();

    static MyFactory()
    {
        _creators["MoneyBack"] = () => new MoneyBack();
        _creators["PlatinumPlus"] = () => new Platinum();
        _creators["TitaniumEdge"] = () => new Titanium();
    }

    public static ICreditCard Create(string name)
    {
        Func<ICreditCard>? creator;

        _creators.TryGetValue(name, out creator);

        if(creator == null) throw new Exception("Invalid type");

        ICreditCard credit = creator();
        return credit;
    }

}
