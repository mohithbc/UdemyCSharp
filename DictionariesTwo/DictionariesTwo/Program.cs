namespace DictionariesTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var codes = new Dictionary<string, string>
           {
               ["US"] = "United States",
               ["FR"] = "France",
               ["ES"] = "Spain"
           };

            if(codes.TryGetValue("FR", out var country))
            {
                Console.WriteLine(country);
            }
            foreach(var item in codes)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
