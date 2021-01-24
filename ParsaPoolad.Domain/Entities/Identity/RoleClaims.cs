
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
   public class RoleClaims
    {
        public String Id { get; set; }
        public String RoleId { get; set; }
        public String ClaimType { get; set; }
        public String ClaimValue { get; set; }
    }
}
