namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();  // Inherited method from Animal class
            myDog.MakeSound(); // Overridden method from Dog class

            Cat myCat = new Cat();
            myCat.MakeSound(); // Overridden method from Cat class
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
        // Virtual method to allow overriding in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    // Derived Class (Child class or Subclass):
    // The class that inherits members from the base class
    class Dog : Animal
    {
        public override void MakeSound() // Overriding the MakeSound method
        {
            base.MakeSound(); // Calling the base class method
            Console.WriteLine("Barking");
        }
    }
    // Hierarchical Inheritance
    // Multiple classes inherit from a single base class
    // Here, both Dog and Cat inherit from Animal
    // Thus, both Dog and Cat have access to the Eat method of Animal
    class Cat : Animal
    {
        public override void MakeSound()
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
