using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        public double CurrentPrice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
