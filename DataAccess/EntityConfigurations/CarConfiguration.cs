﻿using Entities.Concretes;
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



            builder.HasOne(x => x.Color);
            builder.HasOne(x => x.Brand);



        }
    }
}
