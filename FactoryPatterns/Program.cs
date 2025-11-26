using FactoryPatterns.Factory;
using FactoryPatterns.Strategy;
Console.WriteLine("---- Factory Method ----\n");

ICreditCard card = new PlatinumFactory().CreateProduct();
ShowInfo(card);

Console.WriteLine("-----------");

card = new MoneyBackFactory().CreateProduct();
ShowInfo(card);

Console.WriteLine("-----------");
ICreditCard creditCard = MyFactory.Create("TitaniumEdge");
ShowInfo(creditCard);


void ShowInfo(ICreditCard? creditCard)
{
    if (creditCard != null)
    {
        Console.WriteLine($"Card type: {creditCard.GetCardType()}");
        Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
        Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");
    }
    else
    {
        Console.WriteLine("Invalid Card Type");
    }
}