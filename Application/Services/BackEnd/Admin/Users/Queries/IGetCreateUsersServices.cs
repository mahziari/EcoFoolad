using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Users.Queries
{
    public interface IGetCreateUsersServices
    {
        ResultCreateUsersDto Execute();
    }

    public class GetCreateUsersServices : IGetCreateUsersServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        public GetCreateUsersServices(UserManager<Domain.Entities.Users.User> userManager)
        {
            _userManager = userManager;
        }


        public ResultCreateUsersDto Execute()
        {
            // var Users = _UserManager.Users.ToList();

            
            return new ResultCreateUsersDto
            {
                // Users = Users,
            };
        }
    }

    public class ResultCreateUsersDto
    {
        public List<GetIndexUsersUsersDto> Users { get; set; }
    }
    
    public class GetIndexUsersUsersDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
    }

}