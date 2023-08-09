namespace PlanningBet.Users.API.Repositories.Login
{
    public interface ILoginRepository
    {
        string Login(string email, string password);
    }
}
