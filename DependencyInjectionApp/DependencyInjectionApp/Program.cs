namespace DependencyInjectionApp
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering nails!");
        }
    }
    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Cutting wood!");
        }
    }
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;
        // Saw and Hammer are the dependencies of Builder
        // Constructor dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer =  hammer; // Builder is responsible for creating its dependencies
            _saw = saw;
        }
        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("Building a house!");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Hammer hammer = new Hammer();
                Saw saw = new Saw();
                Builder builder = new Builder(hammer, saw);
                builder.BuildHouse();
            }
        }
    }
}
