using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets
{
    public class BetsResponse
    {
        [JsonPropertyName("eventId")]
        public string EventId { get; set; }

        [JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [JsonPropertyName("selectionId")]
        public int SelectionId { get; set; }

        [JsonPropertyName("betId")]
        public string BetId { get; set; }

        [JsonPropertyName("placedDate")]
        public DateTime PlacedDate { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("betOutcome")]
        public string BetOutcome { get; set; }

        [JsonPropertyName("priceRequested")]
        public decimal PriceRequested { get; set; }

        [JsonPropertyName("settledDate")]
        public DateTime SettledDate { get; set; }

        [JsonPropertyName("priceMatched")]
        public decimal PriceMatched { get; set; }

        [JsonPropertyName("sizeSettled")]
        public decimal SizeSettled { get; set; }

        [JsonPropertyName("profit")]
        public decimal Profit { get; set; }

        [JsonPropertyName("itemDescription")]
        public ItemDescriptionResponse MatchDescription { get; set; }
    }
}
