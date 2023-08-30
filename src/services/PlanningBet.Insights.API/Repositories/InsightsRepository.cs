using PlanningBet.Insights.API.Database;
using PlanningBet.Insights.API.Models;

namespace PlanningBet.Insights.API.Repositories
{
    public class InsightsRepository : IInsightsRepository
    {
        private readonly InsightsDbContext _context;

        public InsightsRepository(InsightsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<InsightEntity> FindAll()
        {
            List<InsightEntity> insights = _context.Insights.ToList();
            return insights;
        }
    }
}
