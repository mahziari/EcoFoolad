using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities
{
   public class Role: IdentityRole
    {
        public long LongId { get; set; }
        public string Description { get; set; }
    }
}
