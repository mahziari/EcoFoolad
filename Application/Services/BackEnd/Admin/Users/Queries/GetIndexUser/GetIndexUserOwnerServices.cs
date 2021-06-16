using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.BackEnd.Admin.Users.Queries.GetIndexUser
{
    public class GetIndexUserOwnerServices:IGetIndexUsersServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;

        public GetIndexUserOwnerServices(UserManager<Domain.Entities.Users.User> userManager)
        {
            _userManager = userManager;
        }
        
        public ResultGetIndexUsersDto Execute()
        {
            var users = _userManager.Users
                .OrderByDescending(p=>p.Id)
                .Where(p => p.RequestToBeOwner).ToList();
            
            return new ResultGetIndexUsersDto
            {
                Users = users,
            };
        }
    }
}