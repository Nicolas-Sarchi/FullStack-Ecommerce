using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data.Configurations;
public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("brand");

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasData(
            new Brand
            {
                Id = 1,
                Name = "Apple"
            },
            new Brand
            {
                Id = 2,
                Name = "Samsung"
            }
        );
    }
}