using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class PersonRegister : IPersonRegister
    {
        public List<IObserverPull> observers;
        Person p;

        PersonRegister()
        {
            observers = new List<IObserverPull>();
            p = new Person("Joris Geurts");
        }

        public void Attach(IObserverPull o)
        {
            observers.Add(o);
        }

        public void Detach(IObserverPull o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserverPull o in observers)
            {
                o.Pull();
            }
        }

        public int GetAge()
        {
            return p.age;
        }

        public int GetHeight()
        {
            return p.height;
        }
    }
}
