using Microsoft.AspNetCore.Mvc;
using PlanningBet.Bets.API.Services;
using PlanningBet.Core.Controllers;
using PlanningBet.Insights.API.Repositories;

namespace PlanningBet.Bets.API.Controllers
{
    [Route("api/bets")]
    public class BetsController : BaseController
    {
        private readonly IApiService _apiServices;
        private readonly IBetsRepository _repository;

        public BetsController(IApiService apiServices, IBetsRepository repository)
        {
            _apiServices = apiServices;
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult> SyncBets()
        {
            var bearer = Request.Headers["Authorization"];

            if (bearer != string.Empty)
            {
                var token = bearer.ToString().Split(' ')[1];
                var bets = await _apiServices.SyncBets(token);

                return OkResponse(bets);
            }

            return BadRequest();
        }

        [HttpGet("events")]
        public ActionResult FindAllEvents()
        {
            var teams = _repository.FindAllEvents();

            return OkResponse(teams);
        }
    }
}
