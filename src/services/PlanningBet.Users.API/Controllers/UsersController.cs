using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Core.Interfaces.Controllers;
using PlanningBet.Users.API.Mappers.User;
using PlanningBet.Users.API.Models.User.Requests;
using PlanningBet.Users.API.Repositories.Users;

namespace PlanningBet.Users.API.Controllers
{
    [Route("api/users")]
    public class UsersController : MainController, ICrudController<UserRequest>
    {
        private readonly IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var users = _repository.FindAll();

            return OkResponse(users);
        }

        [HttpGet("{id}")]
        public ActionResult GetById()
        {
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(UserRequest modelRequest)
        {
            try
            {
                if (!modelRequest.IsValid()) return BadRequestResponse(modelRequest.Errors.FirstOrDefault());
                if (!modelRequest.IsValidPassword()) return BadRequestResponse(modelRequest.Errors.FirstOrDefault());

                var user = _repository.Create(modelRequest.ConvertToEntity());

                return OkResponse(user);
            } catch (InvalidDataException ex)
            {
                return BadRequestResponse(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update(UserRequest modelRequest)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
