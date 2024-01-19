using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            _ = builder.ToTable("Stores");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.StoreOwner).WithMany(x => x.Stores).HasForeignKey(x => x.StoreOwnerId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Account).WithOne(x => x.Store).HasForeignKey<Store>(x => x.AccountId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.Address).WithOne(x => x.Store).HasForeignKey<Store>(x => x.AddressId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
