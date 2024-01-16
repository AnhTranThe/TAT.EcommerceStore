using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class MappingProductTagConfiguration : IEntityTypeConfiguration<MappingProductTag>
    {
        public void Configure(EntityTypeBuilder<MappingProductTag> builder)
        {
            _ = builder.ToTable("MappingProductTags");
            _ = builder.HasKey(x => new { x.ProductId, x.TagId });
            _ = builder.HasOne(x => x.Product).WithMany(x => x.MappingProductTags).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Tag).WithMany(x => x.MappingProductTags).HasForeignKey(x => x.TagId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
