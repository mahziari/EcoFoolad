using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Roles.Queries
{
    public interface IGetEditRolesServices
    {
        ResultGetEditRolesDto Execute(string id);
    }

    public class GetEditRolesServices : IGetEditRolesServices
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityDataBaseContext _identityDataBaseContext;

        public GetEditRolesServices(RoleManager<Role> roleManager, IIdentityDataBaseContext identityDataBaseContext)
        {
            _roleManager = roleManager;
            _identityDataBaseContext = identityDataBaseContext;
        }

        public ResultGetEditRolesDto Execute(string id)
        {
            var role = _roleManager.Roles.Where(r => r.Id == id)
                .Select(r=>new GetEditRolesDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                }).FirstOrDefault();

            var claims = _identityDataBaseContext.Claims
                .Select(c=>new Claims()
                {
                    Id = c.Id,
                    ClaimType=c.ClaimType,
                    ClaimValue =c.ClaimValue,
                    ClaimName=c.ClaimName,
                    IsHead=c.IsHead,
                }).ToList();
            
            return new ResultGetEditRolesDto
            {
                Role = role,
                Claims = claims,
            };
        }
    }


    public class ResultGetEditRolesDto
    {
        public GetEditRolesDto Role { get; set; }
        public List<Claims> Claims { get; set; }

    }
    public class GetEditRolesDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    
    public class Claims
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimName { get; set; }
        public bool? IsHead { get; set; }
        public bool IsSelect { get; set; }
    }

}