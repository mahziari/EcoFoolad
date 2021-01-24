using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.Identity
{
   public class Users
    {
        public String Id { get; set; }
        public String UserName { get; set; }
        public String LastName { get; set; }
    }
}
