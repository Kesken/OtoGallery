using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
