using System.ComponentModel.DataAnnotations.Schema;
using TAT.Ecommerce.Domain.Common;
using TAT.Ecommerce.Domain.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    [Table("TAT_Users")]
    public class TAT_User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string NormalizedUserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string NormalizedEmail { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // user Information 
        public string PhoneNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public EGender Gender { get; set; } = EGender.NotDetect;
        public DateTimeOffset Dob { get; set; } = new DateTimeOffset();
        public DateTimeOffset LastLogin { get; set; } = new DateTimeOffset();
        private string _FullName = string.Empty;

        public string FullName
        {
            get => _FullName;
            set
            {
                _FullName = value;
                _FullName = LastName + " " + FirstName;
            }
        }
        public TAT_JwtToken? JwtToken { get; set; }
        public virtual ICollection<TAT_UserRoleMapping>? UserRoleMappings { get; set; }

    }
}
