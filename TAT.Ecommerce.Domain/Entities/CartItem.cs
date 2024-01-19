using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public Guid CartId { get; set; }
        public Cart? Cart { get; set; }

        public int Quantity { get; set; } = 0;
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }


    }
}
