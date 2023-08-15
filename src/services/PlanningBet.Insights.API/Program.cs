using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Config;
using PlanningBet.Insights.API.Infra.Context;
using PlanningBet.Insights.API.Messages;
using PlanningBet.Insights.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();

#region DbContextConfig

var connection = builder.Configuration.GetConnectionString("Postgres");
builder.Services.AddDbContext<InsightsDbContext>(options => options.UseNpgsql(connection));

#endregion

#region RepositoriesConfig

builder.Services.AddScoped<IInsightsRepository, InsightsRepository>();

#endregion

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

builder.Services.AddHostedService<MessageConsumer>();

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
