using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Users.Commands
{
    public interface IEditUsersServices
    {
        ResultEditUsersDto Execute(ResultGetIndexUsersDto resultGetIndexUsersDto);
    }
    public class EditUsersServices : IEditUsersServices
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public EditUsersServices(UserManager<User> userManager, RoleManager<Role> roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public ResultEditUsersDto Execute(ResultGetIndexUsersDto resultGetIndexUsersDto)
        {
            var user = _userManager.FindByIdAsync(resultGetIndexUsersDto.Id).Result;
            var result =_userManager.AddToRoleAsync(user,resultGetIndexUsersDto.RoleName).Result;
            if (!result.Succeeded)
            {
                return new ResultEditUsersDto
                {
                    IsSuccess = true,
                    Message = "Error"
                };
            }
            

            return new ResultEditUsersDto
            {
                IsSuccess = true,
                Message = "Success"
            };
        }
    }

    public class ResultEditUsersDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
}