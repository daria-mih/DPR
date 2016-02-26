using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Person
    {
        public string name;
        public int age;
        public int height;

        public Person(string n)
        {
            name = n;
            age = 0;
            height = 20;
        }
        public void GrowUp()
        {
            age++;
            height += 2;
        }
    }
}
