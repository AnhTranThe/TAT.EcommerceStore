using TAT.Ecommerce.Domain.Common;
using static TAT.Ecommerce.Domain.Helpers.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public ETagType? Type { get; set; }

        public virtual ICollection<MappingCategoryTag>? MappingCategoryTags { get; set; }
        public virtual ICollection<MappingProductTag>? MappingProductTags { get; set; }

    }
}
