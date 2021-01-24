using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands
{
    public interface ICreateRolesServices
    {
        ResultCreateRolesDto Execute(GetIndexRolesRolesDto getIndexRolesRolesDto);
    }

    public class CreateRolesServices : ICreateRolesServices
    {
        private readonly RoleManager<Role> _roleManager;

        public CreateRolesServices(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public ResultCreateRolesDto Execute(GetIndexRolesRolesDto getIndexRolesRolesDto)
        {
            var role = new Role()
            {
                Name = getIndexRolesRolesDto.Name,
                Description = getIndexRolesRolesDto.Description
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
}