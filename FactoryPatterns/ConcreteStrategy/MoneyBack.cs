using FactoryPatterns.Strategy;

namespace FactoryPatterns.ConcreteStrategy
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
