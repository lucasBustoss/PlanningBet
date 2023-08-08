using Microsoft.AspNetCore.Identity;
using PlanningBet.Users.API.Models.User;
using PlanningBet.Users.API.Models.User.Requests;
using System.Security.Claims;

namespace PlanningBet.Users.API.Mappers.User
{
    public static class MapperUserRequest
    {
        public static UserEntity ConvertToEntity(this UserRequest userRequest)
        {
            var user = new UserEntity();
            user.Email = userRequest.Email;
            user.UserName = userRequest.Email;
            user.Password = userRequest.Password;
            user.Role = userRequest.Role;

            var claims = new List<Claim>
            {
                new Claim("Name", userRequest.Name),
                new Claim("PlanName", userRequest.Plan != null ? userRequest.Plan.Name : "Basic"),
                new Claim("PlanExpiresAt", userRequest.Plan != null ? userRequest.Plan.ExpiresAt.ToString() : DateTime.UtcNow.AddMonths(1).ToString())
            };

            if (userRequest.Parameters != null)
            {
                foreach (var favoriteLeague in userRequest.Parameters.FavoriteLeagues)
                    claims.Add(new Claim("FavoriteLeague", favoriteLeague.ToString()));

                foreach (var favoriteMatch in userRequest.Parameters.FavoriteMatches)
                    claims.Add(new Claim("FavoriteMatch", favoriteMatch.ToString()));

                foreach (var favoriteTeam in userRequest.Parameters.FavoriteTeams)
                    claims.Add(new Claim("FavoriteTeam", favoriteTeam.ToString()));

                foreach (var insight in userRequest.Parameters.Insights)
                    claims.Add(new Claim("Insight", insight));
            }

            user.Claims = claims;

            return user;
        }
    }
}
