namespace DelegatesAndEventsTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            string[] stringArray = { "One", "Two", "Three", "Four" };

            PrintArray(intArray);
            PrintArray(stringArray);
            Console.ReadKey();
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        // a generic Method, that accepts a generic datatype
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
