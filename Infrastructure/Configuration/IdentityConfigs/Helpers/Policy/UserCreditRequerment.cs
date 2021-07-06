using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Configuration.IdentityConfigs.Helpers.Policy
{
    public class UserCreditRequerment : IAuthorizationRequirement, IAuthorizationHandler
    {
        public int Credit { get; set; }

        public UserCreditRequerment(int credit)
        {
            Credit = credit;
        }

        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            throw new System.NotImplementedException();
        }
    }


    public class UserCreditHandler : AuthorizationHandler<UserCreditRequerment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            UserCreditRequerment requirement)
        {
            var claim = context.User.FindFirst("Cradit");
            if (claim != null)
            {
                int cradit = int.Parse(claim?.Value);
                if (cradit >= requirement.Credit)
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }
}