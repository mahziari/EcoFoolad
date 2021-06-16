using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.BackEnd.User.Home
{
    public interface IUserHomeServices
    {
        UserHomeInformationPanelDto UserHomeInformation();
    }

    public class UserHomeServices : IUserHomeServices
    {
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly IHttpContextAccessor _httpContext;
        private readonly ICustomDbContext _customDbContext;
        
        public UserHomeServices(UserManager<Domain.Entities.Users.User> userManager, IHttpContextAccessor httpContext,
            ICustomDbContext customDbContext)
        {
            _userManager = userManager;
            _httpContext = httpContext;
            _customDbContext = customDbContext;
        }

        public UserHomeInformationPanelDto UserHomeInformation()
        {
            var user = _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;
            var withMe = (DateTime.Now - user.DataCreated).Days;


            var orderCount = _customDbContext.Orders
                .Include(o => o.OrderItems)
                .Count(o => o.UserId == user.Id);


            return new UserHomeInformationPanelDto
            {
                WithMe = withMe,
                OrderCount = orderCount
            };
        }
    }


    public class UserHomeInformationPanelDto
    {
        public int Purchased { get; set; }
        public int OrderCount { get; set; }
        public int WithMe { get; set; }
        public int NoticeCount { get; set; }
    }
}