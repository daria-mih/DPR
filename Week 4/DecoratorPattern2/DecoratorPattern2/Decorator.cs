using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2
{
    public abstract class Decorator : Order
    {
        public Order order;

        public override double cost()
        {
            return order.cost();
        }

    }
}
