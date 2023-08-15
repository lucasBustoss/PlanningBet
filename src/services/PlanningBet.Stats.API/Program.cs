using PlanningBet.Core.Config;
using PlanningBet.Stats.API.Messages;
using PlanningBet.Stats.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiConfiguration();

#region AuthorizationConfig

builder.Services.AddJwtConfig(builder.Configuration);

#endregion

# region Message Configuration

builder.Services.AddSingleton<IMessageSender, MessageSender>();

#endregion

builder.Services.AddHttpClient();
builder.Services.AddSingleton<IApiServices, ApiServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
