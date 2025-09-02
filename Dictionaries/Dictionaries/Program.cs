namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key - Value
            // Declaring and initializing a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "John");
            employees.Add(2, "Jane");
            employees.Add(3, "Jack");
            employees.Add(4, "Jill");
            // employees.Add(4, "Jill"); // Duplicate key, will throw an exception

            // Accesing items in a dictionary
            string name = employees[2];
            Console.WriteLine(name); // Output: Jane

            employees[2] = "Jane Smith"; // Updating an item
            employees.Remove(4); // Removing an item

            // Iterating through a dictionary
            foreach (KeyValuePair<int, string> kvp in employees)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            bool added = employees.TryAdd(2, "Jim"); // Will return false, key already exists
            if (!added)
            {
                Console.WriteLine("Key 2 already exists.");
            }

        }
    }
}
