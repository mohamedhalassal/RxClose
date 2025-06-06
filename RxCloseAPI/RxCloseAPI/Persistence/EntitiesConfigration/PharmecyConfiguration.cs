namespace RxCloseAPI.Persistence.EntitiesConfiguration;

public class PharmecyConfiguration : IEntityTypeConfiguration<Pharmecy>
{
    public void Configure(EntityTypeBuilder<Pharmecy> builder)
    {
        builder.HasIndex(x => x.UserName).IsUnique();

        builder.Property(x => x.UserName).HasMaxLength(16);
    }
}