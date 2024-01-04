using Advanced_CSharp.Database.Enums;
using ChainStoresManagement.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChainStoresManagement.Data.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;



        // user Information 
        public string PhoneNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public EGender Gender { get; set; } = EGender.NotDetect;
        public DateTimeOffset? Dob { get; set; }
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
        public JwtToken? JwtToken { get; set; }
        public virtual ICollection<UserRole>? UserRoles { get; set; }

    }
}
