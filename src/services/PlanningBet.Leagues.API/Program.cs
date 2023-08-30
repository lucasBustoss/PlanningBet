using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Config;
using PlanningBet.Leagues.API.Database;
using PlanningBet.Leagues.API.Messages;
using PlanningBet.Leagues.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiConfiguration();

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

#region DbContextConfig

var connection = builder.Configuration.GetConnectionString("Postgres");
builder.Services.AddDbContext<LeaguesDbContext>(options => options.UseNpgsql(connection));

var dbContextBuilder = new DbContextOptionsBuilder<LeaguesDbContext>();
dbContextBuilder.UseNpgsql(connection);

#endregion

#region RepositoriesConfig

builder.Services.AddSingleton(new LeaguesRepository(dbContextBuilder.Options));

#endregion
builder.Services.AddHostedService<MessageConsumer>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
