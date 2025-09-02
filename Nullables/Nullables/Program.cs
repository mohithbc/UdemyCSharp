namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null; // This line will cause a compile-time error
            int myAge = 30;
            if (age.HasValue)
            {
                Console.WriteLine($"Age is {age.Value}");
                int sum = age.Value + myAge;
            }
            else
            {
                Console.WriteLine("Age is not provided.");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
