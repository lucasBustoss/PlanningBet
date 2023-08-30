using PlanningBet.Core.Models;

namespace PlanningBet.Leagues.API.Entities
{
    public class League : BaseModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string SeasonName { get; set; }
        public string ImageUrl { get; set; }
    }
}
