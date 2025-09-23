namespace SetterDependencyInjection
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
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House built!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer(); // Creating dependency
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.Hammer = hammer; // Injecting dependency via setter
            builder.Saw = saw; // Injecting dependency via setter
            builder.BuildHouse();
            Console.WriteLine("Hello, World!");
        }
    }
}
