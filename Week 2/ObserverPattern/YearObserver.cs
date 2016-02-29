using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class YearObserver : IObserverPull
    {
        public int ageInYears;
        IPersonRegister p;

        public YearObserver(IPersonRegister p)
        {
            ageInYears = 0;
            this.p = p;
            p.Attach(this);
        }
        public void Pull()
        {
            ageInYears = p.GetAge();
        }

        public int ToForm()
        {
            return ageInYears;
        }
    }
}
