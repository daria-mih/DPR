using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IPersonRegister
    {
        void Attach(IObserverPush o);
        void Detach(IObserverPush o);
        void Notify();
    }
}