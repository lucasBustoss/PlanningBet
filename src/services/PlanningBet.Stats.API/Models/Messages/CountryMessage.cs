using PlanningBet.Core.Integration;
using PlanningBet.Stats.API.Models.ApiResponse;

namespace PlanningBet.Stats.API.Models.Messages
{
    public class CountryMessage : BaseMessage
    {
        public IEnumerable<Country> Countries { get; set; }
    }
}
