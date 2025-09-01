namespace ListsAppTwo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 999.99 },
                new Product { Name = "Smartphone", Price = 699.99 },
                new Product { Name = "Tablet", Price = 399.99 }
            };

            List<Product> CheapProducts = products.Where(p => p.Price < 700).ToList();

            Console.WriteLine("Available Products: ");

            foreach (var product in products)
            {
                Console.WriteLine($"- {product.Name}: ${product.Price}");
            }

            Console.WriteLine("\nAffordable Products (under $700): ");
            foreach (var product in CheapProducts)
            {
                Console.WriteLine($"- {product.Name}: ${product.Price}");
            }
        }
    }
}
