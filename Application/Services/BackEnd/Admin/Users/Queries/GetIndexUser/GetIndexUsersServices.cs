using System.Linq;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.BackEnd.Admin.Users.Queries.GetIndexUser
{
    public class GetIndexUsersServices : IGetIndexUsersServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;

        public GetIndexUsersServices(UserManager<Domain.Entities.Users.User> userManager)
        {
            _userManager = userManager;
        }


        public ResultGetIndexUsersDto Execute()
        {
            var users = _userManager.Users
                .Where(u=>u.UserName!="09129283406")
                .ToList();

      
            return new ResultGetIndexUsersDto
            {
                Users = users,
            };
        }
    }
}