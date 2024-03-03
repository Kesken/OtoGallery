using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);

            builder.Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(50);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
