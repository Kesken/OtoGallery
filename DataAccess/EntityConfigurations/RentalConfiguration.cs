using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals").HasKey(x => x.Id);

            builder.Property(x => x.RentDate).HasColumnName("RentDate").IsRequired();

            builder.Property(x => x.ReturnDate).HasColumnName("ReturnDate");



            builder.HasOne(x => x.Car);
            builder.HasOne(x => x.Customer);

        }
    }
}
