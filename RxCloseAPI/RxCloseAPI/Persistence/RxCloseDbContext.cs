using System.Reflection;

namespace RxCloseAPI.Persistence;

public class RxCloseDbContext(DbContextOptions<RxCloseDbContext>options):DbContext(options)
{
    public DbSet<User> users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
