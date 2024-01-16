using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public User? User { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; }

    }
}
