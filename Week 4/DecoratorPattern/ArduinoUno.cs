using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ArduinoUno : IWattCalculator
    {
        public double Measure()
        {
            return 21.40;
        }
    }
}
