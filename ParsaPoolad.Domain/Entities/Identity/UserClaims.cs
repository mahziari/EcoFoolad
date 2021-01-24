using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
   public class UserClaims
    {
        public String Id { get; set; }
        public String UserId { get; set; }
        public String ClaimType { get; set; }
        public String ClaimValue { get; set; }
    }
}
