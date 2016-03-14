using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2
{
    public class Lens: Decorator
    {
        public Lens(Order o)
        {
            order = o;
        }

        public override double cost()
        {
            return base.cost() + 599;
        }
    }

    public class Filter: Decorator
    {
        public Filter(Order o)
        {
            order = o;
        }

        public override double cost()
        {
            return base.cost() + 23.50;
        }
    }

    public class Extender: Decorator
    {
        public Extender(Order o)
        {
            order = o;
        }

        public override double cost()
        {
            return base.cost() + 429;
        }
    }

}
