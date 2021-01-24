using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
    public class User: IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
    }
}
