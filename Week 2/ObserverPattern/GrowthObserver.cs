using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class HeightObserver : IObserverPull
    {
        IPersonRegister p;
        public int height;

       public HeightObserver(IPersonRegister p)
        {
            height = 0;
            this.p = p;
            p.Attach(this);
        }
        
        public void Pull()
        {
            height = p.GetHeight();
        }

        public int ToForm()
        {
            return height;
        }
    }
}
