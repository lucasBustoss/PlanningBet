using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Middlewares;
using PlanningBet.Users.API.Database.Context;
using PlanningBet.Users.API.Repositories.Login;
using PlanningBet.Users.API.Repositories.Users;
using PlanningBet.Users.API.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

#region DbContextConfig

var connection = builder.Configuration.GetConnectionString("Postgres");
builder.Services.AddDbContext<PlanningDbContext>(options => options.UseNpgsql(connection));

#endregion

#region IdentityConfig

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 1;
}).AddEntityFrameworkStores<PlanningDbContext>();

#endregion

#region AuthorizationConfig

builder.Services.AddSingleton<JWTService>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserPolicy", p => p.RequireAuthenticatedUser().RequireClaim("Profession"));
});

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer();

builder.Services.AddOptions<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme)
    .Configure<IConfiguration>((options, configuration) =>
    {
        options.TokenValidationParameters = new JWTService(configuration).Config();
    });

#endregion

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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
