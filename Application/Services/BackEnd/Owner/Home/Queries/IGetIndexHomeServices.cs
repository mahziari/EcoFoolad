using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using  Domain.Entities.IdealCrm;
using Domain.Entities.Users;


namespace  Application.Services.BackEnd.Owner.Home.Queries
{
    public interface IGetIndexHomeServices
    {
        ResultGetIndexHomeDto Execute();
    }

    public class GetIndexHomeServices : IGetIndexHomeServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContext;

        public GetIndexHomeServices(IIdealCrmDataBaseContext context, UserManager<User> userManager, IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _httpContext = httpContext;
        }
        
        public ResultGetIndexHomeDto Execute()
        {
            var user =  _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;
            var userRegisteryDate = user.DataCreated.ToPersianDateString();

            return new ResultGetIndexHomeDto
            {
                User = user,
                UserRegisteryDate = userRegisteryDate,
            };
        }
    }

    public class ResultGetIndexHomeDto
    {
        public User User { get; set; }
        public string UserRegisteryDate { get; set; }
    }
}