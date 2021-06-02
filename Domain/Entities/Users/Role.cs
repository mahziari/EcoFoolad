﻿using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Commons;
using Microsoft.AspNetCore.Identity;

namespace  Domain.Entities.Users
{
   public class Role: IdentityRole
    { 
        public string Description { get; set; }
        public string Discriminator { get; set; }
    }
}
