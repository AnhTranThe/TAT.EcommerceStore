using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Guid StoreOwnerId { get; set; }
        public StoreOwner StoreOwner { get; set; } = new StoreOwner();
        public string Thumb { get; set; } = string.Empty;
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Gallery>? Galleries { get; set; }
    }
}
