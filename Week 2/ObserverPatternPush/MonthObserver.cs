using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class MonthObserver : IObserverPush
    {
        IPersonRegister p;
        int ageInMonths;
        public MonthObserver(IPersonRegister p)
        {
            this.p = p;
            p.Attach(this);
        }
        public void Push(Person p)
        {
            ageInMonths = p.age * 12;
        }

        public int ToForm()
        {
            return ageInMonths;
        }
    }
}
