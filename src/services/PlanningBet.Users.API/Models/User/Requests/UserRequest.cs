using PlanningBet.Core.Models.Requests;

namespace PlanningBet.Users.API.Models.User.Requests;

public class UserRequest : BaseModelRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public UserPlan Plan { get; set; }
    public UserParameters Parameters { get; set; }

    public override List<string> Errors { get; protected set; }

    public override bool IsValid()
    {
        Validate();

        return Errors.Count == 0;
    }

    public override void Validate()
    {
        Errors = new List<string>();

        if (Name == null || Name == "") Errors.Add("Name cannot be empty or null");
        if (Email == null || Email == "") Errors.Add("Email cannot be empty or null");
        if (Role == null || Role == "") Errors.Add("Role cannot be empty or null");
    }

    public bool IsValidPassword()
    {
        if (Password == null || Password == "") Errors.Add("Password cannot be empty or null");

        return Errors.Count == 0;
    }
}
