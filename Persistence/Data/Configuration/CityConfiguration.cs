using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data.Configurations;
  public class CityConfiguration : IEntityTypeConfiguration<City>
  {
     public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("city");
        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.State)
        .WithMany(p => p.Cities)
        .HasForeignKey(p => p.StateId);

         builder.HasData(
                new City
                {
                    Id = 1,
                    Name = "New York",
                    StateId = 1 
                },
                new City
                {
                    Id = 2,
                    Name = "Los Angeles",
                    StateId = 2 
                }
                
            );
  }
  }