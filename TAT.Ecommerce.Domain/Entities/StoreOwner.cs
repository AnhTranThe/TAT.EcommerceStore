using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class StoreOwner : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public virtual ICollection<Store>? Stores { get; set; }
        public string Role { get; set; } = string.Empty;

    }
}
