using PlanningBet.Users.API.Models.User;
using PlanningBet.Users.API.Models.User.Response;
using System.Security.Claims;

namespace PlanningBet.Users.API.Mappers.User
{
    public static class MapperUserResponse
    {
        public static UserResponse ConvertToResponse(this UserEntity userEntity, bool addPlan, bool addParameters)
        {
            var user = new UserResponse();
            var claims = userEntity.Claims;

            user.Id = userEntity.Id;
            user.Email = userEntity.Email;
            user.Role = userEntity.Role?.ToString() ?? null;
            user.Name = GetClaimValue(claims, "Name");

            if (addPlan)
            {
                user.Plan = new UserPlan();
                user.Plan.Name = GetClaimValue(claims, "PlanName");
                string claimExpiresAt = GetClaimValue(claims, "PlanExpiresAt");

                if (claimExpiresAt != null && claimExpiresAt != string.Empty)
                    user.Plan.ExpiresAt = DateTime.Parse(claimExpiresAt);
            }

            if (addParameters)
            {
                user.Parameters = new UserParameters();
                user.Parameters.FavoriteMatches = GetClaimsList(claims, "FavoriteMatch").ConvertToGuid();
                user.Parameters.FavoriteLeagues = GetClaimsList(claims, "FavoriteLeague").ConvertToGuid();
                user.Parameters.FavoriteTeams = GetClaimsList(claims, "FavoriteTeam").ConvertToGuid();
                user.Parameters.Insights = GetClaimsList(claims, "Insight");
            }
            return user;
        }

        private static string GetClaimValue(IEnumerable<Claim> claims, string claimName)
        {
            var claim = claims.FirstOrDefault(c => c.Type == claimName);

            if (claim != null)
                return claim.Value;

            return "";
        }

        private static List<string> GetClaimsList(IEnumerable<Claim> claims, string claimName)
        {
            var userClaims = claims.Where(c => c.Type == claimName).ToList();
            List<string> results = new List<string>();

            if (userClaims != null && userClaims.Count > 0)
            {
                foreach (var claim in userClaims)
                    results.Add(claim.Value);

                return results;
            }


            return results;
        }

        private static List<Guid> ConvertToGuid(this List<string> claimList)
        {
            List<Guid> listGuid = new List<Guid>();

            if (claimList != null && claimList.Count > 0)
            {
                foreach (var claim in claimList)
                    listGuid.Add(Guid.Parse(claim));
            }

            return listGuid;
        }
    }
}
