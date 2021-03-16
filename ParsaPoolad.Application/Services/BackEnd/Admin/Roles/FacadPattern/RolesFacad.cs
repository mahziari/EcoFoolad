using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.FacadPattern
{
    public class RolesFacad : IRolesFacad
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly ICustomDbContext _context;

        public RolesFacad(RoleManager<Role> roleManager, ICustomDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
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
                return _getEditRolesServices ??= new GetEditRolesServices(_roleManager,_context);
            }
        }
        
        
        private IEditRolesServices _EditRolesServices;
        public IEditRolesServices EditRolesServices
        {
            get
            {
                return _EditRolesServices ??= new EditRolesServices(_roleManager,_context);
            }
        }

    }
}