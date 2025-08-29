namespace ListsAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 47, 22, 33, 14, 25 };

            // Numbers before sorting
            Console.WriteLine("Unsorted list");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            /* A lambda expression consists of two parts
             1. Parameters
             2. Expression or statement block
            
             Parameters are written on the left side of => (this symbol is read as "goes to"
             or "becomes"). 
             The expression or action to perform is on the righ side.
            
             This read as:
             Take an input x and turn it into x multiplied by x.
             X => X * X; */

            /* In C# delegate is like a pointer or reference to a method. It allows you to pass
               methods as arguments to other methods, store them in variables, and call them later.
               This is usefull when you want your code to be flexible and able to handle different
               behaviours that arenot predifned. */


            // Using a Predicate delegate to find numbers greater than or equal 25
            Predicate<int> isGreaterThan25 = n => n >= 25;

            // Any method checks if any element in a collection satisfies a specified condition.
            bool hasLargeNumber = numbers.Any(n => n >= 20);
            if (hasLargeNumber)
            {
                Console.WriteLine("The list contains a number greater than or equal to 20.");
            }
            else
            {
                Console.WriteLine("The list does not contain any number greater than or equal to 20.");
            }

            // This will find all numbers greater than or equal to 25
            List<int> higherEqual = numbers.FindAll(n => n >= 25);
            List<int> result = numbers.FindAll(isGreaterThan25);

            Console.WriteLine("Numbers greater than or equal to 25");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            numbers.Sort();

            Console.WriteLine("Sorted List");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
