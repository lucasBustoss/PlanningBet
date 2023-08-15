using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models
{
    public class ApiResponse<T> : BaseApiResponse
    {
        public T Data { get; set; }
    }
}
