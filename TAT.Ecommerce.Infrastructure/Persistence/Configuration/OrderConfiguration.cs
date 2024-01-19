using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            _ = builder.ToTable("Orders");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.Store).WithMany(x => x.Orders).HasForeignKey(x => x.StoreId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Transaction).WithOne(x => x.Order).HasForeignKey<Order>(x => x.TransactionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
