﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class DayObserver : IObserverPull
    {
        IPersonRegister p { get; set; }
        public int ageInDays;

        DayObserver(IPersonRegister p)
        {
            ageInDays = 0;
            this.p = p;
            p.Attach(this);
        }
        public void Pull()
        {
            int years = p.GetAge();
            ageInDays = (years * 365) + (years / 4);
        }
    }
}