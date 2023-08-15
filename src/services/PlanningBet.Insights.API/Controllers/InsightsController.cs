using Microsoft.AspNetCore.Mvc;
using PlanningBet.Core.Controllers;
using PlanningBet.Insights.API.Repositories;

namespace PlanningBet.Insights.API.Controllers
{
    [Route("api/insights")]
    public class InsightsController : BaseController
    {
        private readonly IInsightsRepository _repository;

        public InsightsController(IInsightsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var insights = _repository.FindAll();

            return OkResponse(insights);
        }
    }
}