using Dapper.Contrib.Extensions;
using System.Net;

namespace Insmart.Core.DTOs
{
    [Table("users_otp")]
    public class UserOTP : BaseEntity
    {
        [Key]
        public int UserOTPId { get; set; }
        public int UserId { get; set; }
        public string OTP { get; set; }
    }
}
