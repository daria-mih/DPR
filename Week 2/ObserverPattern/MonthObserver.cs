using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MonthObserver : IObserverPull
    {
        IPersonRegister p;
        int ageInMonths;
        MonthObserver(IPersonRegister p)
        {
            this.p = p;
            p.Attach(this);
        }
        public void Pull()
        {
            ageInMonths = p.GetAge()*12;
        }
    }
}
