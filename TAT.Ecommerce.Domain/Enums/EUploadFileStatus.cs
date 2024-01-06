using System.ComponentModel;

namespace TAT.Ecommerce.Domain.Enums
{
    public enum EUploadFileStatus
    {
        [Description("Delete")]
        Delete = 0,
        [Description("Active")]
        Active = 1,
        [Description("InActive")]
        InActive = 2,
    }
}
