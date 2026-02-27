namespace FuncGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string> getName = () =>
            {
                return "Jannick";
            };
            var myName = getName();
            Console.WriteLine(getName());

            Func<int, int, int> sum = (x, y) =>
            {
                return x + y;
            };
            Console.WriteLine(sum(3,5));
        }
    }
}
