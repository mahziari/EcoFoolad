using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands
{
    public interface ICreateRolesServices
    {
        ResultCreateRolesDto Execute(CreateRolesServicesDto createRolesServicesDto);
    }

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


    public class ResultCreateRolesDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    public class CreateRolesServicesDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}