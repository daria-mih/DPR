using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Buzzer : Decorator
    {
        public Buzzer(IWattCalculator m) : base(m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (8.91 + decoratedMeasurer.Measure());
        }
    }
    class LED : Decorator
    {
        public LED(IWattCalculator m) : base(m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (12.36 + decoratedMeasurer.Measure());
        }
    }

    class Resistor : Decorator
    {
        public Resistor(IWattCalculator m) : base(m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (17.24 + decoratedMeasurer.Measure());
        }
    }

    class RGBLED : Decorator
    {
        public RGBLED(IWattCalculator m) : base(m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (15.49 + decoratedMeasurer.Measure());
        }
    }
}


