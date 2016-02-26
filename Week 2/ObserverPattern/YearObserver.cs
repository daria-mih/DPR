using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class YearObserver : IObserverPull
    {
        public int ageInYears;
        IPersonRegister p;

        YearObserver(IPersonRegister p)
        {
            ageInYears = 0;
            this.p = p;
            p.Attach(this);
        }
        public void Pull()
        {
            ageInYears = p.GetAge();
        }
    }
}
