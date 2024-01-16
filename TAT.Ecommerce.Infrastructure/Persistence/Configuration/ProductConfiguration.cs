using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            _ = builder.ToTable("Products");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.SubCategory).WithMany(x => x.Products).HasForeignKey(x => x.SubCategoryId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.BrandId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Store).WithMany(x => x.Products).HasForeignKey(x => x.StoreId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
