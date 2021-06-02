using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using Domain.Entities.Users;


namespace  Application.Services.BackEnd.Owner.Profile.Queries
{
    public interface IGetIndexOwnerProfileServices
    {
        ResultGetIndexOwnerProfileDto Execute();
    }

    public class GetIndexOwnerProfileServices : IGetIndexOwnerProfileServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;
        public GetIndexOwnerProfileServices(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<User> userManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
        }


        public ResultGetIndexOwnerProfileDto Execute()
        {
            var user =  _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;

            return new ResultGetIndexOwnerProfileDto
            {
               User=user
            };
        }
    }

    public class ResultGetIndexOwnerProfileDto
    {
        public User User { get; set; }
    }
}