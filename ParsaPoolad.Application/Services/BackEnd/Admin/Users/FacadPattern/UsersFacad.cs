using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Commands;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Users.FacadPattern
{
    public class UsersFacad : IUsersFacad
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public UsersFacad(UserManager<User> userManager,RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        
        private IGetIndexUsersServices _getIndexUsersServices;
        public IGetIndexUsersServices GetIndexUsersServices
        {
            get
            {
                return _getIndexUsersServices ??= new GetIndexUsersServices(_userManager,_roleManager);
            }
        }

        // private IGetCreateUsersServices _getCreateUsersServices;
        // public IGetCreateUsersServices GetCreateUsersServices
        // {
        //     get
        //     {
        //         return _getCreateUsersServices ??= new GetIndexUsersServices(_userManager);
        //     }
        // }
        
        
        // private ICreateUsersServices _createUsersServices;
        // public ICreateUsersServices CreateUsersServices
        // {
        //     get
        //     {
        //         return _createUsersServices ??= new CreateUsersServices(_userManager,_roleManager,_environment);
        //     }
        // }
        //
        //
        // private IGetDetailsUsersServices _getDetailsUsersServices;
        // public IGetDetailsUsersServices GetDetailsUsersServices
        // {
        //     get
        //     {
        //         return _getDetailsUsersServices ??= new GetDetailsUsersServices(_userManager,_roleManager);
        //     }
        // }
        
        
        private IGetEditUsersServices _getEditUsersServices;
        public IGetEditUsersServices GetEditUsersServices
        {
            get
            {
                return _getEditUsersServices ??= new GetEditUsersServices(_userManager,_roleManager);
            }
        }
        
        
        
        private IEditUsersServices _editUsersServices;
        public IEditUsersServices EditUsersServices
        {
            get
            {
                return _editUsersServices ??= new EditUsersServices(_userManager,_roleManager);
            }
        }
        
        
        // private IDeleteUsersServices _deleteUsersServices;
        // public IDeleteUsersServices DeleteUsersServices
        // {
        //     get
        //     {
        //         return _deleteUsersServices ??= new DeleteUsersServices(_userManager,_roleManager,_environment);
        //     }
        // }
    }
}