using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Events;
using PlanningBet.Bets.API.Models.Response.Teams;
using PlanningBet.Bets.API.Utils;
using System.Net;

namespace PlanningBet.Bets.API.Mappers
{
    public static class BetsResponseToEntity
    {
        public static List<BetEntity> ToBetEntity(this List<BetsResponse> betsResponses, List<Team> teams, Dictionary<Guid, string> events)
        {
            List<BetEntity> bets = new List<BetEntity>();

            foreach (var betResponse in betsResponses)
            {
                Guid eventId;

                var betEvent = events.FirstOrDefault(e => e.Value == betResponse.EventId);

                eventId = betEvent.Key;

                var betTeams = betResponse.MatchDescription.EventDescription.Split(" x ");
                var betHomeTeam = Converts.ConvertBetToTeamName(betTeams[0]);
                var betAwayTeam = Converts.ConvertBetToTeamName(betTeams[1]);
                var betPickTeam = Converts.ConvertBetToTeamName(betResponse.MatchDescription.PickDescription);

                var homeTeam = teams.Where(t => t.Name == betHomeTeam || t.CleanName == betHomeTeam).FirstOrDefault();
                var awayTeam = teams.Where(t => t.Name == betAwayTeam || t.CleanName == betAwayTeam).FirstOrDefault();
                Team pickTeam;

                if (betPickTeam == betHomeTeam)
                    pickTeam = homeTeam;
                else
                    pickTeam = awayTeam;

                if (homeTeam != null && awayTeam != null && pickTeam != null && eventId != Guid.Empty)
                {
                    var bet = new BetEntity(betResponse, eventId, pickTeam.Id);
                    bets.Add(bet);
                }
            }

            return bets;
        }

        public static List<EventEntity> ToEventEntity(this List<EventsResponse> eventsResponse, List<Team> teams) 
        {
            List<EventEntity> events = new List<EventEntity>();

            foreach (var eventResponse in eventsResponse)
            {
                var eventTeams = eventResponse.MatchDescription.EventDescription.Split(" x ");
                var eventHomeTeam = Converts.ConvertBetToTeamName(eventTeams[0]);
                var eventAwayTeam = Converts.ConvertBetToTeamName(eventTeams[1]);

                var homeTeam = teams.Where(t => t.Name == eventHomeTeam || t.CleanName == eventHomeTeam).FirstOrDefault();
                var awayTeam = teams.Where(t => t.Name == eventAwayTeam || t.CleanName == eventAwayTeam).FirstOrDefault();

                if (homeTeam != null && awayTeam != null)
                {
                    var betEvent = new EventEntity(eventResponse, homeTeam.Id, awayTeam.Id);
                    events.Add(betEvent);
                }
            }

            return events;
        }
    }
}
