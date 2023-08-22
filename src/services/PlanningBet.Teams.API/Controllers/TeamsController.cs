using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Teams.API.Repositories;

namespace PlanningBet.Teams.API.Controllers
{
    [Route("api/teams")]
    public class TeamsController : BaseController
    {
        private readonly TeamsRepository _repository;

        public TeamsController(TeamsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAllTeams()
        {
            var teams = _repository.FindAll();
            
            return OkResponse(teams);
        }
    }
}
