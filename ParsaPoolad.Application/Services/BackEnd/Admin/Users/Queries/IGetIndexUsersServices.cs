using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Domain.Entities;


namespace ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries
{
    public interface IGetIndexUsersServices
    {
        ResultGetIndexUsersDto Execute();
    }

    public class GetIndexUsersServices : IGetIndexUsersServices
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public GetIndexUsersServices(UserManager<User> userManager, RoleManager<Role> roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public ResultGetIndexUsersDto Execute()
        {
            var users = _userManager.Users
                .Where(u=>u.UserName!="09129283406")
                .ToList();

      
            return new ResultGetIndexUsersDto
            {
                Users = users,
            };
        }
    }

    public class ResultGetIndexUsersDto
    {
        public List<User> Users { get; set; }
        
        public string Id { get; set; }
        public string RoleName { get; set; }
    }

    public class GetIndexUsersRolesDto
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