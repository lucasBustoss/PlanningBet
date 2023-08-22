using PlanningBet.Teams.API.Entities;
using System.Text.Json.Serialization;

namespace PlanningBet.Teams.API.Messages
{
    public class TeamMessage
    {
        public IEnumerable<Team> Teams { get; set; }
    }
}
