using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.BackEnd.Admin.Home
{
    public interface IAdminHomeServices
    {
        
    }

  

    public class AdminHomeServices : IAdminHomeServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly RoleManager<Role> _roleManager;
       
        public AdminHomeServices(UserManager<Domain.Entities.Users.User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
       
    }
    
   
    
    
}