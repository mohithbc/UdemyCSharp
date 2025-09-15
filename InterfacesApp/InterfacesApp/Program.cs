namespace InterfacesApp
{
    public interface IAnimal
    {
        // Interface method (does not have a body)
        void MakeSound();
        void Eat(string food);
    }
    // Dog "implements" the IAnimal interface
    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat ate " + food);
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog rocky = new Dog();
            rocky.MakeSound();
            rocky.Eat("bone");
            Cat tom = new Cat();
            tom.MakeSound();
            tom.Eat("fish");
        }
    }
}
