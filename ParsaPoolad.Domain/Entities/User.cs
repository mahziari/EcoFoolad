using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ParsaPoolad.Domain.Entities
{
    public class User : IdentityUser
    {
        public long LongId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public decimal? Credit { get; set; }
        public string Address { get; set; }
        public DateTime DataCreated { get; set; }
    }
}