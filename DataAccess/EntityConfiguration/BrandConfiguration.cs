using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
        }
    }

    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Brands").HasKey(x => x.Id);

            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice").IsRequired();

            builder.Property(x => x.ModelYear).HasColumnName("ModelYear").IsRequired();

            builder.Property(x => x.Description).HasColumnName("Description").IsRequired();



            builder.HasOne(x => x.Color);
            builder.HasOne(x => x.Brand);



        }
    }
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers").HasKey(x => x.Id);

            builder.Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired();

            builder.HasOne(x => x.User);
        }
    }

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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);

            builder.Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(50);

        }
    }
}
