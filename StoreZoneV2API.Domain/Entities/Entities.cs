namespace StoreZoneV2API.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = default!;
        public decimal Price { get; private set; }
        private Product() { }
        public Product(string name, decimal price)  
        {
            Id = Guid.NewGuid();
            setName(name);
            setPrice(price);
        }

        public void setName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("product name cannot be empty.");
            }
            Name = name;
        }

        public void setPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            Price = price;
        }
    }
}
