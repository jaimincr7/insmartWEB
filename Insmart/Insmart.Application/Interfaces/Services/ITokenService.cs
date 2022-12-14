using Insmart.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insmart.Application.Interfaces.Services
{
    public interface ITokenService
    {
        string CreateToken(TokenRequest request);
    }
}
