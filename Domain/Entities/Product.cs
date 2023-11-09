using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<Review> Reviews { get; set; }
}

}