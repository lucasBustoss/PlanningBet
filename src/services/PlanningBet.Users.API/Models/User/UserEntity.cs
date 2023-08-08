using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace PlanningBet.Users.API.Models.User
{
    public class UserEntity : IdentityUser
    {
        public UserEntity() { }

        public UserEntity(string email, string name)
        {
            Email = email;
            Claims = new List<Claim>() { new Claim("Name", name) };
        }

        public UserEntity(string email, string role, IEnumerable<Claim> claims)
        {
            Role = role;
            Claims = claims;
            Email = email;
        }

        public string Password { get; set; }
        public string Role { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}
