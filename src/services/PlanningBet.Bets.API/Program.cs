using PlanningBet.Bets.API.Services;
using PlanningBet.Core.Config;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();

// Add services to the container.

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

builder.Services.AddHttpClient();
builder.Services.AddSingleton<IApiService, ApiService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
