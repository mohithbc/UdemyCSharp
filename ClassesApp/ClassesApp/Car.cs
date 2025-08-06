using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    /* Its internal which means it can be 
     accessed only within the same class*/
    internal class Car
    {
        // Constructor - is very similar to a method
        // but its diffrent like it has the exact same name
        // as class itself and it doesnot have a return type
        // constructor is called or executed whenever
        // a new object of car is created.
        public Car()
        {
            Console.WriteLine("An object of car has been created");
        }
    }
}
