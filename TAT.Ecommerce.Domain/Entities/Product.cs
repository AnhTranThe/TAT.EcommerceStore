using System.ComponentModel.DataAnnotations;
using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public string MainPhoto { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool HomeFlag { get; set; } = false;
        public bool HotFlag { get; set; } = false;
        public int ViewCount { get; set; } = 0;
        public int Warranty { get; set; } = 0;
        public int Inventory { get; set; } = 0;
        // relationship
        public Guid? SubCategoryId { set; get; }
        public SubCategory? SubCategory { get; set; }
        public Guid? BrandId { set; get; }
        public Brand? Brand { get; set; }
        public Guid StoreId { get; set; }
        public Store? Store { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
        public virtual ICollection<Gallery>? Galleries { get; set; }
        public virtual ICollection<MappingProductTag>? MappingProductTags { get; set; }



    }
}
