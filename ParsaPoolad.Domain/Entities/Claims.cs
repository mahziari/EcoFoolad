using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
   public class Claims
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimName { get; set; }
        public bool? IsHead { get; set; }
        
        
        public virtual Claims Parent { get; set; }
        public virtual ICollection<Claims> SubClaims { get; set; }
        
    }
   
}
