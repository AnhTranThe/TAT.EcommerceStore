using TAT.Ecommerce.Domain.Common;
using static TAT.Ecommerce.Domain.Helpers.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Order : BaseEntity
    {

        public DateTimeOffset? Delivery { get; set; }
        public double TotalAmount { get; set; }
        public double DeliveryCharge { get; set; }
        public EOrderStatus? Status { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string RoadName { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        //relationship
        public Guid StoreId { get; set; }
        public Store Store { get; set; } = new Store();
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; } = new Transaction();
        public ICollection<OrderItem>? OrderItems { get; set; }



    }
}
