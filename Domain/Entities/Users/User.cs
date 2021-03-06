using System;
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
        public int Credit { get; set; }
        public string Address { get; set; }
        public DateTime DataCreated { get; set; }
        public bool RequestToBeOwner { get; set; }
    }
}