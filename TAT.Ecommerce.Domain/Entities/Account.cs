using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Account : BaseEntity
    {
        public double Balance { get; set; } = 0;
        public User User { get; set; } = new User();
        public Store Store { get; set; } = new Store();
        public virtual ICollection<Transaction>? Withdraw { get; set; }
        public virtual ICollection<Transaction>? Deposit { get; set; }
    }
}
