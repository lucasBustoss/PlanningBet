using PlanningBet.Core.Config;
using PlanningBet.Core.Middlewares;
using PlanningBet.Users.API.Config;
using PlanningBet.Users.API.Repositories.Login;
using PlanningBet.Users.API.Repositories.Users;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddApiConfiguration();

#region RepositoriesConfig

builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

#endregion

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<InternalErrorHandlingMiddleware>();
app.UseApiConfiguration(app.Environment);

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
