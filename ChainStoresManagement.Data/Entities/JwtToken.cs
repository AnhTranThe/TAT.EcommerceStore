using System.ComponentModel.DataAnnotations.Schema;

namespace ChainStoresManagement.Data.Entities
{
    [Table("JwtTokens")]
    public class JwtToken
    {
        public Guid UserId { get; set; }
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiredTime { get; set; }
        public User User { get; set; } = new User();

    }
}
