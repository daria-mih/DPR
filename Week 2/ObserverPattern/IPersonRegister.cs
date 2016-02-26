using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IPersonRegister
    {
        void Attach(IObserverPull o);
        void Detach(IObserverPull o);
        void Notify();
        int GetAge();
        int GetHeight();
    }
}