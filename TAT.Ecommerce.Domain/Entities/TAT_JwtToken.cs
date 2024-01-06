using System.ComponentModel.DataAnnotations.Schema;

namespace TAT.Ecommerce.Domain.Entities
{
    [Table("TAT_JwtTokens")]
    public class TAT_JwtToken
    {
        public Guid UserId { get; set; }
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiredTime { get; set; }
        public TAT_User? User { get; set; }

    }
}
