using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            _ = builder.ToTable("Roles");



        }
    }
}
