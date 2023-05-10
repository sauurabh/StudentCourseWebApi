using Microsoft.EntityFrameworkCore;

namespace WebApiTrainingDetail.Auth
{
    public class AuthDbContext:DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }
        public DbSet<RegisterUser> RegisterUser { get; set; }
    }
}
