using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ArduinoDuo : IWattCalculator
    {
        public double Measure()
        {
            return 27.43;
        }
    }
}
