namespace PredicateGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (x) =>
            {
                return x % 2 == 0;
            };
            // Console.WriteLine(isEven(5));
            // We can use prdicate on a list of numbers to find even numbers
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenInts = ints.FindAll(isEven);
            foreach(var num in evenInts)
            {
                Console.WriteLine(num);
            }
        }
    }
}
