using System.Collections;
namespace LegacyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            // Defining an ArrayList with a defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(3.14);
            myArrayList.Add(13);
            myArrayList.Add(true);
            myArrayList.Add('A');
            myArrayList.Add(25); // Duplicates are allowed

            // Delete element with specific value from ArrayList
            myArrayList.Remove(13);
            // Delete element at specific index from ArrayList
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);
            double sum = 0;

            // Object can be of any type, so we need to check the type before performing operations
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine($"String found: {obj}");
                }
            }
            Console.WriteLine($"Sum of numeric values: {sum}");
            Console.ReadKey();
        }
    }
}
