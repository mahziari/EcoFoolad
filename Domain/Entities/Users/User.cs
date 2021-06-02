using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Carts;
using Domain.Entities.Commons;
using Domain.Entities.IdealCrm;
using Microsoft.AspNetCore.Identity;

namespace  Domain.Entities.Users
{
    public class User : IdentityUser
    {
        public int CrmUsersId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public decimal? Credit { get; set; }
        public string Address { get; set; }
        public DateTime DataCreated { get; set; }
        public bool RequestToBeOwner { get; set; }
    }
}