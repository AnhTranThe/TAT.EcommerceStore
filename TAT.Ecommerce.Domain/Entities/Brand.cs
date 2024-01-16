using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities

{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Thumb { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public virtual ICollection<Product>? Products { get; set; }

    }
}
