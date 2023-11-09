using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public int AddressId {get;set;}
    public Address Address {get;set;}
    public int CityId {get;set;}
    public City City {get;set;}
    public int PaymentId {get;set;}
    public Payment Payment {get;set;}
    public ICollection<OrderDetail> OrderDetails { get; set; }
}

}