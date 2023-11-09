using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Role> Rols { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UsersRoles { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories{ get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<StreetType> StreetTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}