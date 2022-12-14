using Insmart.Application.Interfaces.Services;
using Insmart.Application.Models;
using Insmart.Core.Configs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Insmart.Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        public string CreateToken(TokenRequest request)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, request.UserId.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, request.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString(), ClaimValueTypes.Integer64));
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, DateTime.Now.ToString(), ClaimValueTypes.Integer64));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppSettings.Current.JWT.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: AppSettings.Current.JWT.Issuer,
                audience: AppSettings.Current.JWT.Audience,
                expires: DateTime.Now.AddMinutes(AppSettings.Current.JWT.ExpiryMinutes > 0 ? AppSettings.Current.JWT.ExpiryMinutes : 720),
                signingCredentials: creds,
                claims: claims
              );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
