using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Person
    {
        public string name = null;
        public int age = 0;
        public int height = 0;

        public Person(string n)
        {
            name = n;
            age = 0;
            height = 50;
        }
        public Person(string n, int start)
        {
            name = n;
            age = 0;
            height = start;
        }
        public void GrowUp()
        {
            age++;
            height += 2;
        }
    }
}
