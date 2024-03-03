using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Car);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue); // Silinme tarihi varsa verileri getirmeyecek.
        }
    }
}
