using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Stats.API.Services;

namespace PlanningBet.Stats.API.Controllers
{
    [Route("api/stats")]
    public class StatsController : BaseController
    {
        private readonly IApiServices _apiServices;

        public StatsController(IApiServices apiServices)
        {
            _apiServices = apiServices;
        }

        [HttpGet]
        public ActionResult GetStats()
        {
            _apiServices.GetAllStats();
            
            return OkResponse(new { message = "OK" });
        }
    }
}
