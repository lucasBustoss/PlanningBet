using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Users.API.Models.Login;
using PlanningBet.Users.API.Models.Login.Validate;
using PlanningBet.Users.API.Repositories.Login;

namespace PlanningBet.Users.API.Controllers
{
    [Route("api/login")]
    public class LoginController : MainController
    {
        private readonly ILoginRepository _repository;

        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        [HttpPost("")]
        public ActionResult Login(LoginRequest loginRequest)
        {
            try
            {
                var token = _repository.Login(loginRequest.Email, loginRequest.Password);

                return OkResponse(new LoginResponse(loginRequest.Email, token));
            }
            catch (Exception ex)
            {
                return BadRequestResponse(ex.Message);
            }
        }
    }
}
