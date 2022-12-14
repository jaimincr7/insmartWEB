using Insmart.Application.Interfaces.Services;

namespace Insmart.Infrastructure.Services
{
    public class PasswordHashService : IPasswordHashService
    {
        public string CreateHash(string password)
        {
            return password;
        }

        public bool ValidatePassword(string password, string passwordHash)
        {
            return password == passwordHash;
        }

        public bool ValidateOTP(string otp, string otpHash)
        {
            return otp == otpHash;
        }
    }
}
