using PlanningBet.Stats.API.Models.ApiResponse;
using PlanningBet.Stats.API.Models.Messages;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Mapper
{
    public static class CountryToMessage
    {
        public static CountryMessage ToCountryMessage(this IEnumerable<Country> countries)
        {
            var countryMessage = new CountryMessage();
            countryMessage.Countries = countries;

            return countryMessage;
        }
    }
}
