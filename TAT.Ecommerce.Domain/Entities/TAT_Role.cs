using System.ComponentModel.DataAnnotations.Schema;
using TAT.Ecommerce.Domain.Common;

namespace TAT.Ecommerce.Domain.Entities
{
    [Table("TAT_Roles")]
    public class TAT_Role : BaseEntity
    {
        public new Guid Id { get; set; } = Guid.NewGuid();
        public string RoleName { get; set; } = string.Empty;
        public virtual ICollection<TAT_UserRoleMapping>? UserRoleMappings { get; set; }
    }
}
