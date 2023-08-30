using Microsoft.AspNetCore.Mvc;
using PlanningBet.Bets.API.Services;
using PlanningBet.Core.Controllers;

namespace PlanningBet.Bets.API.Controllers
{
    [Route("api/bets")]
    public class BetsController : BaseController
    {
        private readonly IApiService _apiServices;

        public BetsController(IApiService apiServices)
        {
            _apiServices = apiServices;
        }

        [HttpPost]
        public async Task<ActionResult> SyncBets()
        {
            var bearer = Request.Headers["Authorization"];

            if(bearer != string.Empty)
            {
                var token = bearer.ToString().Split(' ')[1];
                var bets = await _apiServices.SyncBets(token);

                return OkResponse(bets);
            }

            return BadRequest();
        }
    }
}
