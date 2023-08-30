using Microsoft.EntityFrameworkCore;
using PlanningBet.Bets.API.Database;
using PlanningBet.Bets.API.Services;
using PlanningBet.Core.Config;
using PlanningBet.Insights.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();

// Add services to the container.
#region DbContextConfig

var connection = builder.Configuration.GetConnectionString("Postgres");
builder.Services.AddDbContext<BetsDbContext>(options => options.UseNpgsql(connection));

#endregion

#region RepositoriesConfig

builder.Services.AddScoped<IBetsRepository, BetsRepository>();

#endregion

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

builder.Services.AddHttpClient();
builder.Services.AddScoped<IApiService, ApiService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
