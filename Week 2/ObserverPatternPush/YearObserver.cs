using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class YearObserver : IObserverPush
    {
        public int ageInYears;
        IPersonRegister p;

        public YearObserver(IPersonRegister p)
        {
            ageInYears = 0;
            this.p = p;
            p.Attach(this);
        }
        public void Push(Person p)
        {
            ageInYears = p.age;
        }

        public int ToForm()
        {
            return ageInYears;
        }
    }
}
