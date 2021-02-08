using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries;
using ParsaPoolad.Domain.Entities.Identity;
using Claims = ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries.Claims;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands
{
    public interface IEditRolesServices
    {
        ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto,string id);
    }

    public class EditRolesServices:IEditRolesServices {
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityDataBaseContext _context;
        public EditRolesServices(RoleManager<Role> roleManager,
            IIdentityDataBaseContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto,string id)
        {

            var currentRole = _roleManager.FindByIdAsync(id).Result;
           
            foreach (var  item in editRolesServicesDto.Claims)
            {
                var claim = _context.Claims.FirstOrDefault(c => c.Id == item.Id);
                
                if (item.IsSelect)
                {
                    var availableRole = _roleManager.GetClaimsAsync(currentRole).Result;
                    var deleteClaim = availableRole.FirstOrDefault(s => s.Value == claim.ClaimValue);
                    if (deleteClaim ==null)
                    {
                        Claim newClaim = new Claim(claim.ClaimType ,claim.ClaimValue,ClaimValueTypes.String);
                        _roleManager.AddClaimAsync(currentRole,newClaim); 
                    }
                }else
                {
                    var availableRole = _roleManager.GetClaimsAsync(currentRole).Result;
                    var deleteClaim = availableRole.FirstOrDefault(s => s.Value == claim.ClaimValue);
                    _roleManager.RemoveClaimAsync(currentRole,deleteClaim);
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