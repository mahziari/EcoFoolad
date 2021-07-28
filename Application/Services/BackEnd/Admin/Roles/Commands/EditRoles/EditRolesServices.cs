using System.Linq;
using System.Security.Claims;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Identity;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Roles.Commands.EditRoles
{
    public class EditRolesServices:IEditRolesServices {
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityDataBaseContext _identityDataBaseContext;
        public EditRolesServices(RoleManager<Role> roleManager, IIdentityDataBaseContext identityDataBaseContext)
        {
            _roleManager = roleManager;
            _identityDataBaseContext = identityDataBaseContext;
        }
        public ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto, string id)
        {

            var currentRole = _roleManager.FindByIdAsync(id.ToString()).Result;
            var claimsRole = _roleManager.GetClaimsAsync(currentRole).Result;
            
            foreach (var  item in editRolesServicesDto.Claims)
            {
                var selectedClaim = _identityDataBaseContext.Claims.FirstOrDefault(c => c.Id == item.Id);

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
}