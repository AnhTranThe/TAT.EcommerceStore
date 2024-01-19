using Microsoft.AspNetCore.Identity;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string NormalizeName { get; set; } = string.Empty;
    }
}
