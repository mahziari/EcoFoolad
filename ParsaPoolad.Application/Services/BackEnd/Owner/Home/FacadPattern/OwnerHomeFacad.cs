using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Owner;
using ParsaPoolad.Application.Services.BackEnd.Owner.Home.Queries;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Home.FacadPattern
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