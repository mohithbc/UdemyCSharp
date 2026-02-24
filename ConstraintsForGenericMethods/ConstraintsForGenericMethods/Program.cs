using System.Net.Http.Headers;

namespace ConstraintsForGenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product();
            var productTwo = new Product();
            var result = Comparer.AreEqual(productOne, productTwo);
        }
    }
    public class Product()
    {

    }
}
