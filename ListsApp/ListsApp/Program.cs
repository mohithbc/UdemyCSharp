namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declrinag and initializing a list of strings
            List<string> colors = new List<string>();
            // Adding items to the list
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Blue");

            // Alternatively, you can initialize a list with values like this:
            List<string> colour =
                [
                    "Red",
                    "Green",
                    "Blue",
                    "Blue"
                ];
            // we can still add more items to this list
            colour.Add("Yellow");


            Console.WriteLine("Current colors in the colors list");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();

            // Removing all occurrences of "Blue" from the list
            bool isDeletingSuccessful = colors.Remove("Blue");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("Blue");
            }

            // Removing an item from the list
            colors.Remove("Green");
            Console.WriteLine("Colors after removing Green");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
