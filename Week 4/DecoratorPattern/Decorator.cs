using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCalculator
{
    public abstract class Decorator : IWattCalculator
    {
        public IWattCalculator decoratedMeasurer;      

        public virtual double Measure()
        {
            return decoratedMeasurer.Measure();
        }      
    }
}
