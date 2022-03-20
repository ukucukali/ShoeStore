using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity
{
    public class AppIdenityDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppIdenityDbContext(DbContextOptions<AppIdenityDbContext> options) : base(options)
        {
        }
    }
}
