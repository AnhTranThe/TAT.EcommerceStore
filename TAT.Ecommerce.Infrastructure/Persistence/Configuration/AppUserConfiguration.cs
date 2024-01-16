using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            _ = builder.ToTable("Users");


            _ = builder.HasOne(x => x.Address).WithOne(x => x.User).HasForeignKey<User>(x => x.AddressId);

            _ = builder.HasOne(x => x.Account).WithOne(x => x.User).HasForeignKey<User>(x => x.AccountId);

            _ = builder.HasOne(x => x.Cart).WithOne(x => x.User).HasForeignKey<User>(x => x.CartId);
        }
    }
}
