using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool HomeFlag { get; set; } = false;
        public string Thumb { get; set; } = string.Empty;
        // relationship

        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<MappingCategoryTag>? MappingCategoryTags { get; set; }
        public virtual ICollection<Gallery>? Galleries { get; set; }
    }
}
