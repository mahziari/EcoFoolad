using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Entities.Dtos;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace  Application.Services.BackEnd.Admin.Users.Commands.ActiveRequestToBeOwner
{
    public interface IActiveRequestToBeOwnerServices
    {
        BaseDto Execute(string id);
    }
    
    public class ActiveRequestToBeOwnerServices:IActiveRequestToBeOwnerServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public ActiveRequestToBeOwnerServices(UserManager<Domain.Entities.Users.User> userManager,RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public BaseDto Execute(string id)
        {
            
            var user = _userManager.FindByIdAsync(id).Result;

            if (_userManager.RemoveFromRoleAsync(user, "User").Result.Succeeded)
            {
                var resultSucceeded = _userManager.AddToRoleAsync(user, "Owner").Result;
                if (resultSucceeded.Succeeded!=true)
                {
                    return new BaseDto
                    (
                        true,
                        new List<string> {"بروز مشکل فنی"}
                    );
                }
            }
            

            return new BaseDto
            (
                true,
                new List<string> {"پنل کاربر به فروشنده تغییر یافت"}
            );
        }
    }
    
}