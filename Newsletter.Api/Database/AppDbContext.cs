using Microsoft.EntityFrameworkCore;

namespace Newsletter.Api.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Subscriber> Subscribers { get; set; }
}
