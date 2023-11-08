using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StreetType : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Address> Addresses { get; set; }
}

}