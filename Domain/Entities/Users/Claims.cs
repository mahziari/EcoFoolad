using System.Collections.Generic;

namespace  Domain.Entities.Users
{
   public class Claims
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimName { get; set; }
        public bool? IsHead { get; set; }
        public int? ParentId { get; set; }
    }
}
