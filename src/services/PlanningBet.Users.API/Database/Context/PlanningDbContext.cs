using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PlanningBet.Users.API.Database.Context;

public class PlanningDbContext : IdentityDbContext<IdentityUser>
{
    public PlanningDbContext() { }

    public PlanningDbContext(DbContextOptions<PlanningDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityUser>(entity =>
        {
            entity.ToTable("Users");
        });

        builder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable("Roles");
            entity.HasData(new IdentityRole[] {
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "User", NormalizedName = "USER" },
            });

        });

        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles");
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins");
        });

        builder.Entity<IdentityRoleClaim<string>>(entity =>
        {
            entity.ToTable("RoleClaims");

        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens");
        });
    }
}
