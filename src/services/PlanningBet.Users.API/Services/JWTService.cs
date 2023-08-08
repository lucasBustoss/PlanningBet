using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PlanningBet.Users.API.Services;

public class JWTService
{
    private IConfiguration _configuration;

    public JWTService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public TokenValidationParameters Config()
    {
        return new TokenValidationParameters()
        {
            ValidateActor = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            ValidAudience = _configuration["JwtBearerTokenSettings:Audience"],
            ValidIssuer = _configuration["JwtBearerTokenSettings:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtBearerTokenSettings:SecretKey"]))
        };
    }
}
