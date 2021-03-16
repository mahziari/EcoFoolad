using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;
using Claims = ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries.Claims;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands
{
    public interface IEditRolesServices
    {
        ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto, string id);
    }

    public class EditRolesServices:IEditRolesServices {
        private readonly RoleManager<Role> _roleManager;
        private readonly ICustomDbContext _context;
        public EditRolesServices(RoleManager<Role> roleManager,
            ICustomDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto, string id)
        {

            var currentRole = _roleManager.FindByIdAsync(id.ToString()).Result;
            var claimsRole = _roleManager.GetClaimsAsync(currentRole).Result;
            
            foreach (var  item in editRolesServicesDto.Claims)
            {
                var selectedClaim = _context.Claims.FirstOrDefault(c => c.Id == item.Id);

                var claimRole = claimsRole.FirstOrDefault(s => s.Value == selectedClaim.ClaimValue);
                var newClaim = new Claim(selectedClaim.ClaimValue ,selectedClaim.ClaimValue,ClaimValueTypes.String);

                if (item.IsSelect && claimsRole.FirstOrDefault(s => s.Value == newClaim.Value)==null)
                {
                    var createClaimRole=_roleManager.AddClaimAsync(currentRole,newClaim).Result;
                }
                else if(item.IsSelect == false && claimsRole.FirstOrDefault(s => s.Value == newClaim.Value)!=null)
                {
                    var deleteClaimRole= _roleManager.RemoveClaimAsync(currentRole,claimRole).Result;
                }
            }

            return new ResultEditRolesDto
            {
                
                IsSuccess = true,
                Message = "نقش با موفقیت ویرایش شد"
            };
        }
    }

    public class ResultEditRolesDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    public class EditRolesServicesDto
    {
        public List<Claims> Claims { get; set; }
    }
}