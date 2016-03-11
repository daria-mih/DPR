using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class Decorator : IWattCalculator
    {
        public IWattCalculator decoratedMeasurer;

        public Decorator(IWattCalculator m)
        {
            decoratedMeasurer = m;
        }

        public virtual double Measure()
        {
            return decoratedMeasurer.Measure();
        }      
    }
}
