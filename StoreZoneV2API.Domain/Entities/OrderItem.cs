namespace StoreZoneV2API.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; } 
        public int OrderId { get; set; } // Foreign key to Order
        public Order? Order { get; set; } // Navigation property to Order
        public Guid ProductId { get; set; } // Foreign key to Product
        public Product? Product { get; set; } // Navigation property to Product
        public int Quantity { get; set; } // Quantity of the product ordered
        public decimal UnitPrice { get; set; } // Price at the time of order
    }
}