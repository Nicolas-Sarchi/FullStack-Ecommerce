using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name {get;set;}
        public int StateId {get;set;}
        public State State {get;set;}
        
    }
    
}