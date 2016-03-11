﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Breadboard : IWattCalculator
    {
        public double Measure()
        {
            return 3.50;
        }
    }
}