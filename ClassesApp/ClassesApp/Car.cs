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
        /*Member variable - its a field inside of a class, so its a varibale inside of a class and outside of the methods*/
        // if you are using a filed inside of the class that you are creating then it is a member variable of that class, model now is the 
        // member variable of the car class

        // private hides the variable from other classes means u cannot access it in program.cs as bmw._model
        private string _model = "";
        private string _brand = "";

        // Constructor - is very similar to a method but its diffrent, like it has the exact same name
        // as class itself and it doesnot have a return type constructor is called or executed whenever a new object of car is created.

        // Custom Constructor
        public Car(string model, string brand)
        {
            _model = model;
            _brand = brand;
            Console.WriteLine($"A car of brand {_brand} & model {_model} has been created");
        }
    }
}
