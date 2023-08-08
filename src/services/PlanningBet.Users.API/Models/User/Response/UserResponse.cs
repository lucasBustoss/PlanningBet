namespace PlanningBet.Users.API.Models.User.Response
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public UserPlan Plan { get; set; }
        public UserParameters Parameters { get; set; }
    }
}
