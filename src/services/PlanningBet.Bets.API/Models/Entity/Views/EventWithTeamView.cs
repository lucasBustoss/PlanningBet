using System.ComponentModel.DataAnnotations.Schema;

namespace PlanningBet.Bets.API.Models.Entity.Views
{
    [Table("events_with_teams_view")]
    public class EventWithTeamView
    {
        public Guid Id { get; set; }
        public string EventCode { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public DateTime Date { get; set; }
        public decimal Profit { get; set; }
        public decimal Commission { get; set; }
    }
}
