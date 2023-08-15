using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models
{
    public class ApiResponseCollection<T> : BaseApiResponse
    {
        public IEnumerable<T> Data { get; set; }
    }
}
