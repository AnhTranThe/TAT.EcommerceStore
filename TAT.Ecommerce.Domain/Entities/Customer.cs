using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public string Role { get; set; } = string.Empty;
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
