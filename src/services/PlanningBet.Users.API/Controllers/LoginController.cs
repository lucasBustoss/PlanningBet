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

        [AllowAnonymous]
        [HttpPost("/api/validate")]
        public ActionResult Validate([FromHeader]string authorization)
        {
            if (authorization == null || authorization == string.Empty) 
                return BadRequestResponse("Token not provided. Token should pass by header");

            var token = authorization.Split(' ')[1];
            var validate = _repository.Validate(token);
            return OkResponse(validate);
        }
    }
}
