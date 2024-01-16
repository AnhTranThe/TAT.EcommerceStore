using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            _ = builder.ToTable("Carts");
            _ = builder.HasKey(x => x.Id);


        }
    }
}
