using System.ComponentModel;

namespace TAT.Ecommerce.Domain.Enums
{
    public enum EUserStatus
    {
        [Description("Block")]
        Block = 0,
        [Description("Active")]
        Active = 1,
        [Description("InActive")]
        InActive = 2,

    }
}
