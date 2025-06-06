namespace RxCloseAPI.Persistence.EntitiesConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
       builder.Property(x => x.FirstName).HasMaxLength(100);
       builder.Property(x => x.LastName).HasMaxLength(100);
    }
}