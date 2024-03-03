using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers").HasKey(x => x.Id);

            builder.Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired();

            builder.HasOne(x => x.User);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
