using PlanningBet.Insights.API.Models;

namespace PlanningBet.Insights.API.Repositories
{
    public interface IInsightsRepository
    {
        IEnumerable<InsightEntity> FindAll();
    }
}
