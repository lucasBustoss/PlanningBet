using PlanningBet.Bets.API.Models.Response;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace PlanningBet.Bets.API.Services
{
    public class ApiService : IApiService
    {
        public readonly HttpClient _httpClient;
        public readonly string _apiUrl;
        public readonly string _apiKey;
        public readonly string _username;
        public readonly string _password;

        public ApiService(IConfiguration configuration)
        {
            _apiUrl = configuration.GetValue<string>("Betfair:AppUrl");
            _apiKey = configuration.GetValue<string>("Betfair:ApiKey");
            _username = configuration.GetValue<string>("Betfair:User");
            _password = configuration.GetValue<string>("Betfair:Password");

            _httpClient = new HttpClient() { BaseAddress = new Uri(_apiUrl) };
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-Application", _apiKey);
        }

        public async void SyncBets()
        {
            var token = await GetAuthToken();

            _httpClient.DefaultRequestHeaders.Add("X-Authentication", token);

            var body = new Dictionary<string, string>
            {
                { "betStatus", "SETTLED" }
            };

            var request = await _httpClient.PostAsJsonAsync("listClearedOrders/", body);

            if(request.IsSuccessStatusCode)
            {
                var responseString = await request.Content.ReadAsStringAsync();
                ListClearedOrdersResponse response = JsonSerializer.Deserialize<ListClearedOrdersResponse>(responseString);
            }
        }

        #region Private methods

        private async Task<string> GetAuthToken()
        {
            string token = "";
            HttpClient httpAuth = new HttpClient();
            httpAuth.BaseAddress = new Uri("https://identitysso.betfair.com/api/login");
            httpAuth.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
            httpAuth.DefaultRequestHeaders.Add("Accept", "application/json");
            httpAuth.DefaultRequestHeaders.Add("X-Application", _apiKey);

            var formAuth = new Dictionary<string, string>
            {
                { "username", _username },
                { "password", _password },
            };

            var content = new FormUrlEncodedContent(formAuth);

            var request = await httpAuth.PostAsync("", content);

            if(request.IsSuccessStatusCode)
            {
                string responseString = await request.Content.ReadAsStringAsync();
                AuthResponse response = JsonSerializer.Deserialize<AuthResponse>(responseString);
                token = response.Token;
            }

            return token;
        }

        #endregion
    }
}
