using ApplicationCore.Constants;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public static class AppIdenityDbContextSeed
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.ADMIN));

            var adminEmail = "admin@example.com";
            var adminUser = new ApplicationUser() { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
            await userManager.CreateAsync(adminUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(adminUser, AuthorizationConstants.Roles.ADMIN);

            var userEmalil = "demouser@example.com";
            var demoUser = new ApplicationUser() { UserName = userEmalil, Email = userEmalil, EmailConfirmed = true };
            await userManager.CreateAsync(demoUser, AuthorizationConstants.DEFAULT_PASSWORD);

        }
    }
}
