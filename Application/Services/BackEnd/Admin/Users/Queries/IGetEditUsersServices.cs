using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Users.Queries
{
    public interface IGetEditUsersServices
    {
        ResultGetEditUsersDto Execute(string id);
    }

    public class GetEditUsersServices : IGetEditUsersServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public GetEditUsersServices(UserManager<Domain.Entities.Users.User> userManager, RoleManager<Role> roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public ResultGetEditUsersDto Execute(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            var role = _userManager.GetRolesAsync(user).Result;
            var roles = _roleManager.Roles.Where(r=>r.Name!="SeniorProgrammer").ToList();
            

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
        public Domain.Entities.Users.User User { get; set; }
        public IList<string> Role { get; set; }
        public List<Role> Roles { get; set; }
        
        // Validation for Parsing Model Objects to view
        public string RoleName { get; set; }
        public string UserId { get; set; }
    }
}