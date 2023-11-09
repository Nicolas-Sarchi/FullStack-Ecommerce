using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
public class Address : BaseEntity
{
    public string MainNumber { get; set; }
    public string SecondaryNumber { get; set; }
    public string Street { get; set; }
    public int StreetTypeId { get; set; }
    public StreetType StreetType { get; set; }
    public string AdditionalInformation { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<Order> Orders { get; set; }
}

}