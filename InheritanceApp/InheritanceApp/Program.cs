namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();  // Inherited method from Animal class
            myDog.Bark(); // Method from Dog class
        }
    }
    // Base Class (Parent class or Superclass):
    // The class whose members are inherited
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eatting");
        }
    }
    // Derived Class (Child class or Subclass):
    // The class that inherits members from the base class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
    // Hierarchical Inheritance
    // Multiple classes inherit from a single base class
    // Here, both Dog and Cat inherit from Animal
    // Thus, both Dog and Cat have access to the Eat method of Animal
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing");
        }
    }
    // Multi-level Inheritance
    // A class can inherit from a derived class, forming a chain of inheritance
    // Here, Rocky inherits from Dog, which in turn inherits from Animal
    // Thus, Rocky has access to members of both Dog and Animal classes
    class Rocky : Dog
    {
        public void Growl()
        {
            Console.WriteLine("Growling");
        }
    }
}
