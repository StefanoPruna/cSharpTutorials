using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Human
    {
        public string name;
        public int age;
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
