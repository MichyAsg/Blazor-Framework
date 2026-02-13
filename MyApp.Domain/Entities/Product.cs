namespace MyApp.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            if (price < 0)
                throw new ArgumentException("Prijs mag niet negatief zijn");

            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }
    }
}
