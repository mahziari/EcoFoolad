using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ParsaPoolad.Domain.Entities.DbTwoEntities
{
   // public class Sliders: IdentityRole
   public class Sliders
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }
        public string Url { get; set; }
    }
}