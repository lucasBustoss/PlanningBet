using PlanningBet.Core.Models;

namespace PlanningBet.Users.API.Models.Login
{
    public class LoginResponse
    {
        public LoginResponse(string email, string token)
        {
            Email = email;
            Token = token;
        }

        public string Email { get; set; }
        public string Token { get; set; }
    }
}
