using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries
{
    public interface IGetCreateRolesServices
    {
        ResultGetCreateRolesDto Execute();
    }

    public class GetCreateRolesServices : IGetCreateRolesServices
    {
        private readonly RoleManager<Role> _roleManager;
        public GetCreateRolesServices(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public ResultGetCreateRolesDto Execute()
        {

            return new ResultGetCreateRolesDto();
        }
    }

    public class ResultGetCreateRolesDto
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
    }
}