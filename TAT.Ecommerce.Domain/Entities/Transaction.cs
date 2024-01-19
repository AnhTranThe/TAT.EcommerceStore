using TAT.Ecommerce.Domain.Common;
using static TAT.Ecommerce.Domain.Helpers.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid FromAccountId { get; set; }
        public Account FromAccount { get; set; } = new Account();
        public Guid ToAccountId { get; set; }
        public Account ToAccount { get; set; } = new Account();
        public double Amount { get; set; }
        public ETransactionType? Type { get; set; }
        public string? Description { get; set; }
        public Order Order { get; set; } = new Order();
    }
}
