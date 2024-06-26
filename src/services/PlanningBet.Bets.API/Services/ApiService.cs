﻿using Microsoft.Extensions.Logging;
using PlanningBet.Bets.API.Mappers;
using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Response;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Events;
using PlanningBet.Bets.API.Models.Response.Teams;
using PlanningBet.Insights.API.Repositories;
using System.Net.Http.Headers;
using System.Text.Json;

namespace PlanningBet.Bets.API.Services
{
    public class ApiService : IApiService
    {
        public readonly HttpClient _httpClient;
        private readonly IBetsRepository _repository;
        public readonly string _apiUrl;
        public readonly string _apiKey;
        public readonly string _username;
        public readonly string _password;
        public readonly string _startDate;
        private string _token;

        public ApiService(IConfiguration configuration, IBetsRepository repository)
        {
            _repository = repository;
            
            _apiUrl = configuration.GetValue<string>("Betfair:AppUrl");
            _apiKey = configuration.GetValue<string>("Betfair:ApiKey");
            _username = configuration.GetValue<string>("Betfair:User");
            _password = configuration.GetValue<string>("Betfair:Password");
            _startDate = configuration.GetValue<string>("Betfair:StartDate");

            _httpClient = new HttpClient() { BaseAddress = new Uri(_apiUrl) };
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-Application", _apiKey);

            _token = Login();
            _httpClient.DefaultRequestHeaders.Add("X-Authentication", _token);
        }

        public string Login()
        {
            return GetAuthToken().Result;
        }

        public async Task<List<EventEntity>> SyncBets(string auth)
        {
            var events = await GetEvents(auth);

            Dictionary<Guid, string> eventsIds = new Dictionary<Guid, string>();
            foreach (var betEvent in events)
                eventsIds.Add(betEvent.Id, betEvent.EventCode);

            await GetBets(auth, eventsIds);
            
            return events;
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

            if (request.IsSuccessStatusCode)
            {
                string responseString = await request.Content.ReadAsStringAsync();
                AuthResponse response = JsonSerializer.Deserialize<AuthResponse>(responseString);
                token = response.Token;
            }

            return token;
        }

        private async Task<List<EventEntity>> GetEvents(string auth)
        {
            var body = new Dictionary<string, object>
            {
                { "betStatus", "SETTLED" },
                { "includeItemDescription", "true"  },
                { "settledDateRange", new Dictionary<string, string>
                    {
                        { "from", _startDate }
                    }
                },
                { "groupBy", "EVENT" }
            };

            var request = await _httpClient.PostAsJsonAsync("listClearedOrders/", body);

            if (request.IsSuccessStatusCode)
            {
                var teams = await GetTeams(auth);
                string responseString = await request.Content.ReadAsStringAsync();
                ListClearedOrdersResponse<EventsResponse> response = JsonSerializer.Deserialize<ListClearedOrdersResponse<EventsResponse>>(responseString);

                var events = response.Orders.ToEventEntity(teams);

                await _repository.CreateOrUpdateEvents(events);

                return events;
            }
            else
            {
                var errorMessage = JsonSerializer.Deserialize<object>(await request.Content.ReadAsStringAsync());
                Console.WriteLine(errorMessage);
                Console.WriteLine(request.StatusCode);
                return null;
            }
        }

        private async Task<List<BetEntity>> GetBets(string auth, Dictionary<Guid, string> events)
        {
            var eventCodes = events.Values.ToList();
            
            var body = new Dictionary<string, object>
            {
                { "betStatus", "SETTLED" },
                { "includeItemDescription", "true"  },
                { "eventIds",  eventCodes },
                { "settledDateRange", new Dictionary<string, string>
                    {
                        { "from", _startDate }
                    }
                }
            };

            var request = await _httpClient.PostAsJsonAsync("listClearedOrders/", body);

            if (request.IsSuccessStatusCode)
            {
                var teams = await GetTeams(auth);
                string responseString = await request.Content.ReadAsStringAsync();
                ListClearedOrdersResponse<BetsResponse> response = JsonSerializer.Deserialize<ListClearedOrdersResponse<BetsResponse>>(responseString);

                var bets = response.Orders.ToBetEntity(teams, events);
                await _repository.CreateOrUpdateBets(bets);

                return bets;
            }
            else
            {
                var errorMessage = JsonSerializer.Deserialize<object>(await request.Content.ReadAsStringAsync());
                Console.WriteLine(errorMessage);
                Console.WriteLine(request.StatusCode);
                return null;
            }
        }

        private async Task<List<Team>> GetTeams(string auth)
        {
            HttpClient httpPlanning = new HttpClient();
            httpPlanning.BaseAddress = new Uri("http://localhost:5004/api/");
            httpPlanning.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth);

            var request = await httpPlanning.GetAsync("teams");

            if (request.IsSuccessStatusCode)
            {
                var responseTeamsString = await request.Content.ReadAsStringAsync();

                TeamsResponse responseTeam = JsonSerializer.Deserialize<TeamsResponse>(responseTeamsString);
                return responseTeam.Teams;
            } else
            {
                var errorMessage = JsonSerializer.Deserialize<object>(await request.Content.ReadAsStringAsync());
                Console.WriteLine(errorMessage);
                Console.WriteLine(request.StatusCode);
                return null;
            }

            #endregion
        }
    }
}
