using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Persistence.Data.Configurations;
  public class OrderConfiguration : IEntityTypeConfiguration<Order>
  {
     public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("order");
        // Nombre de la tabla en la base de datos

            builder.HasKey(o => o.Id); // Definir la clave primaria

            builder.Property(o => o.UserId).IsRequired();
            builder.Property(o => o.OrderDate).IsRequired();
            builder.Property(o => o.Status).IsRequired().HasMaxLength(50); // Ajusta la longitud máxima según tus necesidades
            builder.Property(o => o.AddressId).IsRequired();
            builder.Property(o => o.CityId).IsRequired();
            builder.Property(o => o.PaymentId).IsRequired();

            // Definir relaciones con otras entidades
            builder.HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Opcional: Define la acción de eliminación en cascada

            builder.HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict); // Ajusta la acción de eliminación según tus necesidades

            builder.HasOne(o => o.City)
                .WithMany()
                .HasForeignKey(o => o.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Payment)
                .WithMany()
                .HasForeignKey(o => o.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración para la colección de OrderDetails
            builder.HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Opcional: Define la acción de eliminación en cascada

            // Datos de ejemplo para la entidad Order
            builder.HasData(
                new Order
                {
                    Id = 1,
                    UserId = 1,
                    OrderDate = DateTime.Now,
                    Status = "En proceso",
                    AddressId = 1,
                    CityId = 1,
                    PaymentId = 1
                },
                new Order
                {
                    Id = 2,
                    UserId = 2,
                    OrderDate = DateTime.Now,
                    Status = "Enviado",
                    AddressId = 2,
                    CityId = 2,
                    PaymentId = 2
                }
                // Agrega más pedidos y datos según sea necesario
            );
        
  }
  }