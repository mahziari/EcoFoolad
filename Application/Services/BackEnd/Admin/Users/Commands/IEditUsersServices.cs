using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Identity;
 
using  Application.Services.BackEnd.Admin.Users.Queries;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Users.Commands
{
    public interface IEditUsersServices
    {
        ResultEditUsersDto Execute(ResultGetEditUsersDto resultGetEditUsersDto);
    }
    public class EditUsersServices : IEditUsersServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly RoleManager<Role> _roleManager;
       
        public EditUsersServices(UserManager<Domain.Entities.Users.User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public ResultEditUsersDto Execute(ResultGetEditUsersDto resultGetEditUsersDto)
        {
            var user = _userManager.FindByIdAsync(resultGetEditUsersDto.UserId).Result;

            foreach (var item in _userManager.GetRolesAsync(user).Result.ToList())
            {
                var identityResult = _userManager.RemoveFromRoleAsync(user, item).Result;
            }
            
            var result =_userManager.AddToRoleAsync(user,resultGetEditUsersDto.RoleName).Result;
            if (!result.Succeeded)
            {
                return new ResultEditUsersDto
                {
                    IsSuccess = false,
                    Message = "خطایی در ویرایش نقش کاربر رخ داده است"
                };
            }
            return new ResultEditUsersDto
            {
                IsSuccess = true,
                Message = "ویرایش نقش کاربر با موفقیت انجام شد"
            };
        }
    }

    public class ResultEditUsersDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
}