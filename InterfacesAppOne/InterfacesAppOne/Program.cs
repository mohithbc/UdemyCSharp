namespace InterfacesAppOne
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating polymorphism
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myDog.Speak(); // Output: The dog barks.
            myCat.Speak(); // Output: The cat meows.
        }
    }
}
