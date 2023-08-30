using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response
{
    public class AuthResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
