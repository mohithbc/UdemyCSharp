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

        public static int NumberOfCars = 0;


        /*Member variable - its a field inside of a class, so its a varibale inside of a class and outside of the methods*/
        // if you are using a filed inside of the class that you are creating then it is a member variable of that class, model now is the 
        // member variable of the car class

        // private hides the variable from other classes means u cannot access it in program.cs as bmw._model
        // Backing field of the Model Property
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        // property
       // public string Model { get; set; }

        // Constructor - is very similar to a method but its diffrent, like it has the exact same name
        // as class itself and it doesnot have a return type constructor is called or executed whenever a new object of car is created.

        // Custom Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A car of brand {Brand} & model {Model} has been created");
        }

        public Car()
        {
            NumberOfCars++;
        }

        // Property( lambda expressions )
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing");
                    _brand = "DefaultValue";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }


        public void Drive()
        {
            Console.WriteLine("Im driving");
        }
    }
}
