using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Car
    {
        string name;
        string make;
        string model;
        int year;

        //Constructor
        public Car(string name, string make, string model, int year)
        {
            this.name = name;
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + name + " of the " + make + " from the year " + year + " and " + model);
        }
    }
}
