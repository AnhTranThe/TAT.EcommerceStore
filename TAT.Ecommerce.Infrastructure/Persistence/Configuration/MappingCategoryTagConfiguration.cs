using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class MappingCategoryTagConfiguration : IEntityTypeConfiguration<MappingCategoryTag>
    {
        public void Configure(EntityTypeBuilder<MappingCategoryTag> builder)
        {
            _ = builder.ToTable("MappingCategoryTags");
            _ = builder.HasKey(x => new { x.CategoryId, x.TagId });
            _ = builder.HasOne(x => x.Category).WithMany(x => x.MappingCategoryTags).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Tag).WithMany(x => x.MappingCategoryTags).HasForeignKey(x => x.TagId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
