using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries
{
    public interface IGetEditUsersServices
    {
        ResultGetEditUsersDto Execute(string id);
    }

    public class GetEditUsersServices : IGetEditUsersServices
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public GetEditUsersServices(UserManager<User> userManager, RoleManager<Role> roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public ResultGetEditUsersDto Execute(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var role = _userManager.GetRolesAsync(user).Result;
            var roles = _roleManager.Roles.ToList();
            

            return new ResultGetEditUsersDto
            {
                User = user,
                Role = role,
                Roles=roles
            };
        }
    }

    public class ResultGetEditUsersDto
    {
        public User User { get; set; }
        public IList<string> Role { get; set; }
        public List<Role> Roles { get; set; }
        
        // Validation for Parsing Model Objects to view
        public string Id { get; set; }
        public string RoleName { get; set; }
    }

    public class RolesDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    
    public class RoleDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    
    public class UserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Claim { get; set; }
    }
    
    
}