using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    internal class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage):base(beverage) { }

        public override decimal GetCost()
        {
            var cost = _beverage.GetCost() + 0.5m;
            return cost;
        }

        public override StringBuilder Description()
        {
            return _beverage.Description().Append($"+milk");
        }
    }
}
