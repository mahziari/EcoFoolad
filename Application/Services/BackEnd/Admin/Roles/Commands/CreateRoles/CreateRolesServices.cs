using Microsoft.AspNetCore.Identity;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Roles.Commands.CreateRoles
{
    public class CreateRolesServices : ICreateRolesServices
    {
        private readonly RoleManager<Role> _roleManager;

        public CreateRolesServices(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public ResultCreateRolesDto Execute(CreateRolesServicesDto createRolesServicesDto)
        {
            var role = new Role()
            {
                Name = createRolesServicesDto.Name,
                Description = createRolesServicesDto.Description
            };
            var result = _roleManager.CreateAsync(role).Result;
            if (!result.Succeeded)
            {
                return new ResultCreateRolesDto
                {
                    IsSuccess = true,
                    Message = result.Errors.ToString()
                };
            }

            return new ResultCreateRolesDto
            {
                IsSuccess = true,
                Message = "رول با موفقیت اضافه شد"
            };
        }
    }
}