using PlanningBet.Core.Interfaces.Repositories;
using PlanningBet.Users.API.Models.User;
using PlanningBet.Users.API.Models.User.Response;

namespace PlanningBet.Users.API.Repositories.Users
{
    public interface IUsersRepository : ICrudRepository<UserEntity, UserResponse>
    {
    }
}
