namespace TAT.Ecommerce.Domain.Entities
{
    public class MappingCategoryTag
    {

        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid TagId { get; set; }
        public Tag? Tag { get; set; }

    }
}
