using System.ComponentModel.DataAnnotations.Schema;

namespace ChainStoresManagement.Data.Entities
{
    [Table("UserRoles")]
    public class UserRole
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
