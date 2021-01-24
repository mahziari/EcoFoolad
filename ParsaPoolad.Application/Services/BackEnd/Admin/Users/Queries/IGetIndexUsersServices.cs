using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.Identity;


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
            var users = _userManager.Users.ToList();

            // foreach (var item in users)
            // {
            //   var userId = item.Id;
            //   var user = _userManager.FindByIdAsync(item.Id).Result;
            //   var role = _userManager.GetRolesAsync(user).Result;
            // }

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