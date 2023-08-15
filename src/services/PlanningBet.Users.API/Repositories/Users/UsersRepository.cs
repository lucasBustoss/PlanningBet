using Microsoft.AspNetCore.Identity;
using PlanningBet.Users.API.Mappers.User;
using PlanningBet.Users.API.Models.User;
using PlanningBet.Users.API.Models.User.Response;

namespace PlanningBet.Users.API.Repositories.Users;

public class UsersRepository : IUsersRepository
{
    private readonly UserManager<IdentityUser> _userManager;

    public UsersRepository(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public IEnumerable<UserResponse> FindAll()
    {
        var users = _userManager.Users.ToList();
        List<UserResponse> result = new List<UserResponse>();

        foreach (var user in users)
        {
            var userName = _userManager.GetClaimsAsync(user).Result.FirstOrDefault(c => c.Type == "Name").Value;
            var userResponse = new UserEntity(user.Email, userName);

            result.Add(userResponse.ConvertToResponse(false, false));
        }

        return result;
    }

    public UserResponse FindById(Guid id)
    {
        throw new NotImplementedException();
    }

    public UserResponse Create(UserEntity modelEntity)
    {
        try
        {
            var result = _userManager.CreateAsync(modelEntity, modelEntity.Password).Result;

            if (!result.Succeeded)
                throw new InvalidDataException();

            var roleResult = _userManager.AddToRoleAsync(modelEntity, modelEntity.Role).Result;

            if (!roleResult.Succeeded)
                throw new InvalidDataException();

            if (modelEntity.Claims.Count() > 0)
            {
                var claimResult = _userManager.AddClaimsAsync(modelEntity, modelEntity.Claims).Result;

                if (!claimResult.Succeeded)
                    throw new InvalidDataException();
            }

            return modelEntity.ConvertToResponse(true, false);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public UserResponse Update(UserEntity modelEntity)
    {
        throw new NotImplementedException();
    }
}
