using PlanningBet.Core.Models;

namespace PlanningBet.Insights.API.Models
{
    public class InsightEntity : BaseModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
    }
}
