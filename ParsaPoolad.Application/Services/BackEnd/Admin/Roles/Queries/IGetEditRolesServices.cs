using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries
{
    public interface IGetEditRolesServices
    {
        ResultGetEditRolesDto Execute(string id);
    }

    public class GetEditRolesServices : IGetEditRolesServices
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityDataBaseContext _context;
        public GetEditRolesServices(RoleManager<Role> roleManager, IIdentityDataBaseContext context)
        {
            _roleManager = roleManager;
            _context = context;
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

            var claims = _context.Claims
                .Select(c=>new Claims()
                {
                    Id = c.Id,
                    ClaimType=c.ClaimType,
                    ClaimValue =c.ClaimValue,
                    ClaimName=c.ClaimName
                })
                
                .ToList();
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
        public bool IsSelect { get; set; }
        
    }
    
}