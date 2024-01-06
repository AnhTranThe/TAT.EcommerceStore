using System.ComponentModel;

namespace TAT.Ecommerce.Domain.Enums
{
    /// <summary>
    /// EGender
    /// </summary>
    public enum EGender
    {
        [Description("NotDetect")]
        NotDetect = 0,
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2,
        [Description("Other")]
        Other = 3,
    }
}
