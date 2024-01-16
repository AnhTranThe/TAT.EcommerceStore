using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{

    public class StoreOwnerConfiguration : IEntityTypeConfiguration<StoreOwner>
    {
        public void Configure(EntityTypeBuilder<StoreOwner> builder)
        {
            _ = builder.ToTable("StoreOwners");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.User).WithMany(x => x.StoreOwners).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);



        }
    }
}
