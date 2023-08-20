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
        public ActionResult SyncBets()
        {
            _apiServices.SyncBets();

            return OkResponse(new { message = "OK" });
        }
    }
}
