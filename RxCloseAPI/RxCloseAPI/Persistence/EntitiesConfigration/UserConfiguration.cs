namespace RxCloseAPI.Persistence.EntitiesConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(x => x.UserName).IsUnique();

        builder.Property(x => x.UserName).HasMaxLength(16);
    }
}