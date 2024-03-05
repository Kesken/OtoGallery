using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(x => x.Id);

            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice").IsRequired();

            builder.Property(x => x.ModelYear).HasColumnName("ModelYear").IsRequired();

            builder.Property(x => x.Description).HasColumnName("Description").IsRequired();

            builder.HasMany(x => x.CarColors)
               .WithOne(cc => cc.Car)
               .HasForeignKey(cc => cc.CarId);

            builder.HasOne(x => x.Brand);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
