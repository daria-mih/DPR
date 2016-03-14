using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCalculator
{
    public class Breadboard : IWattCalculator
    {
        public double Measure()
        {
            return 3.50;
        }
    }
    public class ArduinoUno : IWattCalculator
    {
        public double Measure()
        {
            return 21.40;
        }
    }
    public class ArduinoDuo : IWattCalculator
    {
        public double Measure()
        {
            return 27.43;
        }
    }
}
