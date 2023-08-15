using PlanningBet.Stats.API.Models.Messages;
using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse
{
    public class Country
    {
        [JsonPropertyName("id")]
        public int CountryId { get; set; }

        [JsonPropertyName("country")]
        public string CountryName { get; set; }

        [JsonPropertyName("name_pt")]
        public string CountryNamePortuguese { get; set; }

        [JsonPropertyName("iso")]
        public string CountryIso { get; set; }

        [JsonPropertyName("iso_number")]
        public int? CountryIsoNumber { get; set; }
    }
}
