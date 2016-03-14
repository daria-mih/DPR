using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2
{
    public class PhotoCamera : Order
    {
        public override double cost()
        {
            return 1200;
        }
    }
}
