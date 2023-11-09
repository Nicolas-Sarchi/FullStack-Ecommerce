using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data.Configurations;
  public class CountryConfiguration : IEntityTypeConfiguration<Country>
  {
     public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("country");

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);

          builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Estados Unidos"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canadá"
                }
               
            );
  }
  }