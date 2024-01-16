using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TAT.Ecommerce.Domain.Helpers.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        private string _FullName = string.Empty;
        [Required]
        public string FullName
        {
            get => _FullName;
            set
            {
                _FullName = value;
                _FullName = LastName + " " + FirstName;
            }
        }
        public EGender Gender { get; set; } = EGender.NotDetect;
        public DateTimeOffset? Dob { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTimeOffset? LastLogin { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
        // relationship
        public virtual ICollection<StoreOwner>? StoreOwners { get; set; }
        public virtual ICollection<Customer>? Customers { get; set; }
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }
        public Cart? Cart { get; set; }
        public Guid CartId { get; set; }



    }
}
