namespace CustomInterfaceConstraint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> repository = new Repository<Product>();
            var Product = new Product();
            repository.Add(Product);
        }
    }
    class Product : IEntity
    {
        public int Id { get; }
    }
}
