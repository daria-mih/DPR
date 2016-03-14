using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCalculator
{
    public class Buzzer : Decorator
    {
        public Buzzer(IWattCalculator m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (8.91 + decoratedMeasurer.Measure());
        }
    }
    public class LED : Decorator
    {
        public LED(IWattCalculator m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (12.36 + decoratedMeasurer.Measure());
        }
    }

    public class Resistor : Decorator
    {
        public Resistor(IWattCalculator m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (17.24 + decoratedMeasurer.Measure());
        }
    }

    public class RGBLED : Decorator
    {
        public RGBLED(IWattCalculator m)
        {
            decoratedMeasurer = m;
        }

        public override double Measure()
        {
            return (15.48 + decoratedMeasurer.Measure());
        }
    }
}


