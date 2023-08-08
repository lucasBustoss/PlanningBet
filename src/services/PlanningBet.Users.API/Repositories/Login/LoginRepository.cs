using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PlanningBet.Users.API.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PlanningBet.Users.API.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly JWTService _jwtConfiguration;

        public LoginRepository(UserManager<IdentityUser> userManager, IConfiguration configuration, JWTService jwtConfiguration)
        {
            _userManager = userManager;
            _configuration = configuration;
            _jwtConfiguration = jwtConfiguration;
        }

        public string Login(string email, string password)
        {
            var user = _userManager.FindByEmailAsync(email).Result;

            if (user == null)
                throw new InvalidDataException("User or password is incorrect.");

            var claims = _userManager.GetClaimsAsync(user).Result;

            if (!_userManager.CheckPasswordAsync(user, password).Result)
                throw new UnauthorizedAccessException("User or password is incorrect.");

            var key = Encoding.ASCII.GetBytes(_configuration["JwtBearerTokenSettings:SecretKey"]);
            var subjectClaims = new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.Name, claims.FirstOrDefault(c => c.Type == "Name").Value),
                new Claim(ClaimTypes.Email, email),
                new Claim("id", user.Id)
            });
            subjectClaims.AddClaims(claims);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subjectClaims,
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),
                Audience = _configuration["JwtBearerTokenSettings:Audience"],
                Issuer = _configuration["JwtBearerTokenSettings:Issuer"],
                Expires = DateTime.UtcNow.AddHours(Convert.ToInt32(_configuration["JwtBearerTokenSettings:ExpireTimeInHours"]))
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenObject = tokenHandler.CreateToken(tokenDescriptor);

            var token = tokenHandler.WriteToken(tokenObject);

            return token;
        }

        public bool Validate(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                tokenHandler.ValidateToken(token, _jwtConfiguration.Config(), out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
