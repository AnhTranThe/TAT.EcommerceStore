using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            _ = builder.ToTable("SubCategories");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.Category).WithMany(x => x.SubCategories).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
