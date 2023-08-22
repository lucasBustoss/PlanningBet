using PlanningBet.Bets.API.Enums;

namespace PlanningBet.Bets.API.Mappers
{
    public static class MarketTypeToEnum
    {
        public static MarketType ConvertToMarketType(string marketType)
        {
            if (marketType == "MATCH_ODDS")
                return MarketType.MatchOdds;

            return MarketType.NotDefined;
        }
    }
}
