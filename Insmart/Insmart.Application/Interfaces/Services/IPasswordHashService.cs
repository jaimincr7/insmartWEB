using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insmart.Application.Interfaces.Services
{
    public interface IPasswordHashService
    {
        string CreateHash(string password);
        bool ValidatePassword(string password, string passwordHash);
        bool ValidateOTP(string otp, string otpHash);
    }
}
