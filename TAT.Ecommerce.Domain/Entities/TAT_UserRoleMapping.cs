using System.ComponentModel.DataAnnotations.Schema;

namespace TAT.Ecommerce.Domain.Entities
{
    [Table("TAT_UserRoleMappings")]
    public class TAT_UserRoleMapping
    {
        public Guid UserId { get; set; }
        public TAT_User? User { get; set; }
        public Guid RoleId { get; set; }
        public TAT_Role? Role { get; set; }
    }
}
