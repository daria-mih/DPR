using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class MonthObserver : IObserverPull
    {
        IPersonRegister p;
        int ageInMonths;
        public MonthObserver(IPersonRegister p)
        {
            this.p = p;
            p.Attach(this);
        }
        public void Pull()
        {
            ageInMonths = p.GetAge()*12;
        }

        public int ToForm()
        {
            return ageInMonths;
        }
    }
}
