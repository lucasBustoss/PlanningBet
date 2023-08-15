using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models
{
    public class BaseApiResponse
    {
        public bool Success { get; set; }
        public Pager Pager { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Pager
    {
        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("max_page")]
        public int MaxPage { get; set; }

        [JsonPropertyName("results_per_page")]
        public int ResultsPerPage { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("request_limit")]
        public int? RequestLimit { get; set; }

        [JsonPropertyName("request_remaining")]
        public int? RequestRemaining { get; set; }

        [JsonPropertyName("request_reset_message")]
        public string? RequestResetMessage { get; set; }
    }
}
