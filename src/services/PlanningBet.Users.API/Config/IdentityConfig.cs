using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Config;
using PlanningBet.Users.API.Database.Context;

namespace PlanningBet.Users.API.Config
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("Postgres");
            services.AddDbContext<UsersDbContext>(options => options.UseNpgsql(connection));

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 1;
            }).AddEntityFrameworkStores<UsersDbContext>();

            services.AddJwtConfig(configuration);

            return services;
        }
    }
}
