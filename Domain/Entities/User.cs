namespace Domain.Entities;
public class User : BaseEntity
{


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
      public int AddressId { get; set; }
    public Address Address { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UserRole> UsersRoles { get; set; }
}