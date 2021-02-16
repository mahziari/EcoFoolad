using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
   public class Claims
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimName { get; set; }
        public bool? IsHead { get; set; }
        
        
        public virtual Claims Parent { get; set; }
        public virtual ICollection<Claims> SubClaims { get; set; }
        
    }
   
}
