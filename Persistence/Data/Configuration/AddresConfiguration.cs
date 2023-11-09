using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data.Configurations;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Address");

        builder.Property(e => e.MainNumber)
            .IsRequired();

        builder.Property(e => e.SecondaryNumber).IsRequired();

        builder.Property(e => e.Street)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.AdditionalInformation)
            .HasMaxLength(200);

        builder.HasOne(e => e.City)
            .WithMany()
            .HasForeignKey(e => e.CityId);

        builder.HasOne(e => e.StreetType)
            .WithMany(e => e.Addresses)
            .HasForeignKey(e => e.StreetTypeId);
        builder.HasData(
            new Address
            {
                Id = 1, 
                MainNumber = "123",
                SecondaryNumber = "Apt 4B",
                Street = "1234 Elm Street",
                StreetTypeId = 1, 
                AdditionalInformation = "Near the park",
                CityId = 1, 
            },
            new Address
            {
                Id = 2,
                MainNumber = "456",
                SecondaryNumber = "Unit 7",
                Street = "5678 Oak Avenue",
                StreetTypeId = 2, 
                AdditionalInformation = "Downtown",
                CityId = 2, 
            }
        );
    }
}