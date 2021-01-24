using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
   public class Roles
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String NormalizedName { get; set; }
        public String ConcurrencyStamp { get; set; }
    }
}
