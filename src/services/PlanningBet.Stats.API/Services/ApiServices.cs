using PlanningBet.Stats.API.Mapper;
using PlanningBet.Stats.API.Messages;
using PlanningBet.Stats.API.Models;
using PlanningBet.Stats.API.Models.ApiResponse;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueMatches;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStatsInfo;
using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;
using PlanningBet.Stats.API.Models.Messages;
using PlanningBet.Stats.API.Models.Model.Leagues;
using PlanningBet.Stats.API.Models.Model.Leagues.Matches;
using PlanningBet.Stats.API.Models.Model.Leagues.Standing;
using PlanningBet.Stats.API.Models.Model.Teams;
using System.Text;

namespace PlanningBet.Stats.API.Services
{
    public class ApiServices : IApiServices
    {
        private HttpClient _httpClient;
        IMessageSender _messageSender;
        private readonly string _apiUrl;
        private readonly string _apiKey;
        private readonly string _syncMode;

        public ApiServices(IMessageSender messageSender, IConfiguration configuration)
        {
            _apiUrl = configuration.GetValue<string>("FootyStats:url");
            _apiKey = configuration.GetValue<string>("FootyStats:authKeyTest");
            _syncMode = configuration.GetValue<string>("FootyStats:syncMode");

            _httpClient = new HttpClient() { BaseAddress = new Uri(_apiUrl) };
            _messageSender = messageSender ?? throw new ArgumentNullException(nameof(messageSender));
        }

        public async void GetAllStats()
        {
            var leagues = await GetLeagues();
            var teams = await GetTeams(leagues);

            GetLeagueStanding(leagues);
        }

        public async Task<List<League>> GetLeagues()
        {
            var queryString = new StringBuilder();
            queryString.Append($"key={_apiKey}");

            if (_syncMode == "test")
                queryString.Append($"&country=911");

            if (_syncMode != "test")
                queryString.Append($"&chosen_leagues_only=true");

            //chosen_leagues_only = _syncMode == "test" ? (bool?)null : true,
            //country = _syncMode == "test" ? 911 : (int?)null,

            var response = await _httpClient.GetFromJsonAsync<ApiResponseCollection<LeagueResponse>>($"league-list?{queryString}");
            var countries = await GetCountries();
            var leaguesResponse = response.Data;
            List<League> leagues = new List<League>();

            #region Regra de negócio

            var actualYear = DateTime.Now.Year;

            foreach (var leagueResponse in leaguesResponse)
            {
                if (_syncMode == "test" && leagueResponse.LeagueFullName != "England Premier League")
                    continue;

                LeagueSeason season;

                if (_syncMode == "test")
                {
                    season =
                        leagueResponse.Seasons.Where(s =>
                            s.LeagueSeasonId.ToString() == "1625" ||
                            s.LeagueSeasonId.ToString() == "2012" ||
                            s.LeagueSeasonId.ToString() == "4759")
                        .FirstOrDefault();
                }
                else
                {
                    int index = leagueResponse.Seasons.Count() - 1;
                    season = leagueResponse.Seasons.ToList()[index];
                }

                var seasonYear = season.LeagueSeasonYear;
                var seasonName =
                    seasonYear.ToString().Length == 8 ?
                        $"{seasonYear.ToString().Substring(0, 4)}/{seasonYear.ToString().Substring(4, 4)}" :
                        seasonYear.ToString();

                if (_syncMode == "test" || seasonYear == actualYear || seasonYear.ToString().Contains(actualYear.ToString()))
                {
                    var statsInfo = await GetLeagueStatsInfo(season.LeagueSeasonId);

                    if (statsInfo != null)
                    {
                        var country = countries.Where(c => c.CountryName == statsInfo.Country).FirstOrDefault();

                        var matches = await GetLeagueMatches(season.LeagueSeasonId);
                        League league = new League(leagueResponse, seasonName, season.LeagueSeasonId, statsInfo.Name, matches);
                        leagues.Add(league);
                    }
                }


            }

            #endregion

            _messageSender.SendMessage<LeagueMessage>(leagues.ToLeagueMessage(), "leagues");

            return leagues;
        }

        public async Task<List<Team>> GetTeams(List<League> leagues)
        {
            List<Team> teams = new List<Team>();
            foreach (var league in leagues)
            {
                var teamsLeague = await GetTeamsFromLeague(league.Code, 1, null);
                teamsLeague.ForEach(tl =>
                {
                    teams.Add(new Team(tl));
                });
            }

            _messageSender.SendMessage<TeamMessage>(teams.ToTeamMessage(), "teams");

            return teams;
        }

        public async void GetLeagueStanding(List<League> leagues)
        {
            List<LeagueStanding> standings = new List<LeagueStanding>();
            foreach (var league in leagues)
            {
                var standingRequest = await GetStandingFromLeague(league.Code);
                standings.Add(new LeagueStanding(standingRequest));
            }

            _messageSender.SendMessage<LeagueStandingMessage>(standings.ToLeagueStandingMessage(), "standings");
        }

        public void GetFixtures()
        {
            throw new NotImplementedException();
        }

        public void GetLastStats()
        {
            throw new NotImplementedException();
        }

        #region Private methods

        private async Task<List<Country>> GetCountries()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponseCollection<Country>>($"country-list?key={_apiKey}");

            return response.Data.ToList();
        }

        private async Task<List<TeamResponse>> GetTeamsFromLeague(int seasonId, int currentPage, List<TeamResponse> teamsAdded)
        {
            List<TeamResponse> teams = teamsAdded != null ? teamsAdded : new List<TeamResponse>();

            StringBuilder queryString = new StringBuilder();
            queryString.Append($"key={_apiKey}");
            queryString.Append($"&include=stats");
            queryString.Append($"&currentPage={currentPage}");
            queryString.Append($"&season_id={seasonId}");

            var response = await _httpClient.GetFromJsonAsync<ApiResponseCollection<TeamResponse>>($"league-teams?{queryString}");
            var pages = response.Pager.MaxPage;

            teams.AddRange(response.Data);

            if(currentPage != pages)
            {
                var newPage = currentPage + 1;
                await GetTeamsFromLeague(seasonId, newPage, teams);
            }

            return teams;
        }

        private async Task<LeagueStatsInfo> GetLeagueStatsInfo(int seasonId)
        {
            bool isValidSeasonId = _syncMode != "test" || (_syncMode == "test" && (seasonId == 1625 || seasonId == 2012 || seasonId == 4759));

            if (!isValidSeasonId) throw new InvalidDataException();

            string queryString = $"key={_apiKey}&season_id={seasonId}";
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<LeagueStatsInfoRequest>>($"league-season?{queryString}");
            LeagueStatsInfoRequest leagueStatsInfoResponse;

            if (response != null && response.Success && response.Pager != null && response.Pager.TotalResults > 0)
            {
                leagueStatsInfoResponse = response.Data;

                LeagueStatsInfo leagueStatsInfo = new LeagueStatsInfo(leagueStatsInfoResponse);
                return leagueStatsInfo;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private async Task<LeagueStandingRequest> GetStandingFromLeague(int seasonId)
        {
            string queryString = $"key={_apiKey}&season_id={seasonId}";
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<LeagueStandingRequest>>($"league-tables?{queryString}");

            return response.Data;
        }

        private async Task<List<LeagueMatches>> GetLeagueMatches(int seasonId)
        {
            bool isValidSeasonId = _syncMode != "test" || (_syncMode == "test" && (seasonId == 1625 || seasonId == 2012 || seasonId == 4759));
            if (!isValidSeasonId) throw new InvalidDataException();

            string queryString = $"key={_apiKey}&season_id={seasonId}";
            var response = await _httpClient.GetFromJsonAsync<ApiResponse<List<LeagueMatchesResponse>>>($"league-matches?{queryString}");
            List<LeagueMatchesResponse> leagueMatchesResponse;

            if (response != null && response.Success && response.Pager != null && response.Pager.TotalResults > 0)
            {
                leagueMatchesResponse = response.Data;
                List<LeagueMatches> leagueMatches = new List<LeagueMatches>();

                foreach (var leagueMatchResponse in leagueMatchesResponse)
                {
                    LeagueMatches leagueMatch = new LeagueMatches(leagueMatchResponse);
                    leagueMatches.Add(leagueMatch);
                }

                return leagueMatches;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        #endregion
    }
}
