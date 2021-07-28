using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Identity;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Admin;
using  Application.Services.BackEnd.Admin.Roles.Commands;
using  Application.Services.BackEnd.Admin.Roles.Commands.CreateRoles;
using  Application.Services.BackEnd.Admin.Roles.Commands.EditRoles;
using  Application.Services.BackEnd.Admin.Roles.Queries;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Roles.FacadPattern
{
    public class RolesFacad : IRolesFacad
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityDataBaseContext _identityDataBaseContext;
        public RolesFacad(RoleManager<Role> roleManager, IIdentityDataBaseContext identityDataBaseContext)
        {
            _roleManager = roleManager;
            _identityDataBaseContext = identityDataBaseContext;
        }
        
        
        
        private IGetIndexRolesServices _getIndexRolesServices;
        public IGetIndexRolesServices GetIndexRolesServices
        {
            get
            {
                return _getIndexRolesServices ??= new GetIndexRolesServices(_roleManager);
            }
        }
        
        
        
        private IGetCreateRolesServices _getCreateRolesServices;
        public IGetCreateRolesServices GetCreateRolesServices
        {
            get
            {
                return _getCreateRolesServices ??= new GetCreateRolesServices(_roleManager);
            }
        }

        private ICreateRolesServices _createRolesServices;
        public ICreateRolesServices CreateRolesServices
        {
            get
            {
                return _createRolesServices ??= new CreateRolesServices(_roleManager);
            }
        }

        private IGetEditRolesServices _getEditRolesServices;
        public IGetEditRolesServices GetEditRolesServices
        {
            get
            {
                return _getEditRolesServices ??= new GetEditRolesServices(_roleManager,_identityDataBaseContext);
            }
        }
        
        
        private IEditRolesServices _editRolesServices;
        public IEditRolesServices EditRolesServices
        {
            get
            {
                return _editRolesServices ??= new EditRolesServices(_roleManager,_identityDataBaseContext);
            }
        }

    }
}