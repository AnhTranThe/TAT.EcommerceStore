using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            _ = builder.ToTable("Galleries");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.Category).WithMany(x => x.Galleries).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Store).WithMany(x => x.Galleries).HasForeignKey(x => x.StoreId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.SubCategory).WithMany(x => x.Galleries).HasForeignKey(x => x.SubCategoryId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Product).WithMany(x => x.Galleries).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
