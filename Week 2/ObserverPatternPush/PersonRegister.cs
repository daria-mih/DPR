using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class PersonRegister : IPersonRegister
    {
        public List<IObserverPush> observers;
        public Person p;

        public PersonRegister()
        {
            observers = new List<IObserverPush>();
            p = new Person("Joris Geurts", 0);
        }

        public void CreateKillPerson(bool alive)
        {
            if (alive)
                p = new Person("Joris Geurts");
        }

        public void Attach(IObserverPush o)
        {
            observers.Add(o);
            Notify();
        }

        public void Detach(IObserverPush o)
        {
            observers.Remove(o);
            Notify();
        }

        public void Notify()
        {
            foreach (IObserverPush o in observers)
            {
                o.Push(p);
            }
        }

    }
}
