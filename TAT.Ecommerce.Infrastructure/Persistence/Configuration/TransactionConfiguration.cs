using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.Ecommerce.Domain.Entities;

namespace TAT.Ecommerce.Infrastructure.Persistence.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            _ = builder.ToTable("Transactions");
            _ = builder.HasKey(x => x.Id);
            _ = builder.HasOne(x => x.FromAccount).WithMany(x => x.Withdraw).HasForeignKey(x => x.FromAccountId).OnDelete(DeleteBehavior.Restrict);
            _ = builder.HasOne(x => x.ToAccount).WithMany(x => x.Deposit).HasForeignKey(x => x.ToAccountId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
