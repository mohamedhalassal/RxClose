namespace RxCloseAPI.Persistence;

public class RxCloseDbContext(DbContextOptions<RxCloseDbContext> options) :
    IdentityDbContext<User>(options)
{
    public DbSet<Pharmecy> users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
