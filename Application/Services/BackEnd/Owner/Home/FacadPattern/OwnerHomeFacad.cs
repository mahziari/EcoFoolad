using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Owner;
using  Application.Services.BackEnd.Owner.Home.Queries;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Owner.Home.FacadPattern
{
    public class OwnerHomeFacad : IOwnerHomeFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContext;


        public OwnerHomeFacad(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
            _httpContext = httpContext;
        }
        
        private IGetIndexHomeServices _getIndexHomeServices;
        public IGetIndexHomeServices GetIndexHomeServices
        {
            get
            {
                return _getIndexHomeServices ??= new GetIndexHomeServices(_context,_userManager,_httpContext);
            }
        }
    }
}