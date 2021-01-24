using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries
{
    public interface IGetCreateUsersServices
    {
        ResultCreateUsersDto Execute();
    }

    public class GetCreateUsersServices : IGetCreateUsersServices
    {
        private readonly UserManager<User> _userManager;
        public GetCreateUsersServices(UserManager<User> userManager)
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