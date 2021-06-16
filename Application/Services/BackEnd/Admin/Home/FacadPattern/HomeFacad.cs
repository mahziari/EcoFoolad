using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Factory.Queries.GetIndexFactory;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.BackEnd.Admin.Home.FacadPattern
{
    public class HomeFacad:IHomeFacad
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly RoleManager<Role> _roleManager;
       
        public HomeFacad(UserManager<Domain.Entities.Users.User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
     
        private IAdminHomeServices _adminHomeServices;
        public IAdminHomeServices AdminHomeServices
        {
            get
            {
                return _adminHomeServices ??= new AdminHomeServices(_userManager,_roleManager);
            }
        }

    }
}