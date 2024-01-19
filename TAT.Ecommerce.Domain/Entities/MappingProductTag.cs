namespace TAT.Ecommerce.Domain.Entities
{
    public class MappingProductTag
    {

        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid TagId { get; set; }
        public Tag? Tag { get; set; }

    }
}
