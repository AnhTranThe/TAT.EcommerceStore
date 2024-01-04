using System.ComponentModel.DataAnnotations.Schema;

namespace ChainStoresManagement.Data.Entities
{
    [Table("Roles")]
    public class Role
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RoleName { get; set; } = string.Empty;
        public virtual ICollection<UserRole>? UserRoles { get; set; }
    }
}
