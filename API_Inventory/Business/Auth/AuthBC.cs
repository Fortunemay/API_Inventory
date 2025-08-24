using Inventory_API.Interface.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Inventory_API.Business.Auth
{
    public class AuthBC : IJwtAuth
    {
        private readonly IConfiguration configuration;
        public AuthBC(IConfiguration config)
        {
            configuration = config;
        }

        public string Authentication(string employeeId, string email)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, employeeId),
                    new Claim(ClaimTypes.Email, email)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("AppSettings:Token")!));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
                var tokenDescritor = new JwtSecurityToken(
                    issuer:configuration.GetValue<string>("AppSettings:Issuer"),
                    audience:configuration.GetValue<string>("AppSettings:Audience"),
                    claims:claims,
                    expires:DateTime.UtcNow.AddDays(1),
                    signingCredentials:creds
                    );

                return new JwtSecurityTokenHandler().WriteToken(tokenDescritor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
