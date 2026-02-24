namespace MultipleGenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(100, "one hundred");
            box.Display();
        }
    }
}
