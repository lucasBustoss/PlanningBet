using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Leagues.API.Repositories;

namespace PlanningBet.Leagues.API.Controllers
{
    [Route("api/leagues")]
    public class LeaguesController : BaseController
    {
        private readonly LeaguesRepository _repository;

        public LeaguesController(LeaguesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAllLeagues()
        {
            var leagues = _repository.FindAll();
            
            return OkResponse(leagues);
        }
    }
}
