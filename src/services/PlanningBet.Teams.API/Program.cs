using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Config;
using PlanningBet.Teams.API.Database;
using PlanningBet.Teams.API.Messages;
using PlanningBet.Teams.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiConfiguration();

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

#region DbContextConfig

var connection = builder.Configuration.GetConnectionString("Postgres");
builder.Services.AddDbContext<TeamsDbContext>(options => options.UseNpgsql(connection));

var dbContextBuilder = new DbContextOptionsBuilder<TeamsDbContext>();
dbContextBuilder.UseNpgsql(connection);

#endregion

#region RepositoriesConfig

builder.Services.AddSingleton(new TeamsRepository(dbContextBuilder.Options));
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
