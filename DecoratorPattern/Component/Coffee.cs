using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    internal class Coffee : IBeverage
    {
        public decimal GetCost()
        {
            return 1.5m;
        }

        public StringBuilder Description()
        {
            return new StringBuilder("Coffee");
        }
    }
}
