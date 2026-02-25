namespace GenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => 
            {
                Console.WriteLine("Hello World"); 
            };
            action();

            Action<int> numPrint = (x) =>
            {
                Console.WriteLine(x);
            };
            numPrint(20);

            Action<float, int, double> sum = (a, b, c) =>
            {
                Console.WriteLine(a+b+c);
            };
            sum(10, 20, 30);
        }
    }
}
