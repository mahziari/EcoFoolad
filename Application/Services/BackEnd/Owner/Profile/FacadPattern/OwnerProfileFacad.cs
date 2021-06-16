using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Owner;
using  Application.Services.BackEnd.Owner.Profile.Commands;
using  Application.Services.BackEnd.Owner.Profile.Queries;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Owner.Profile.FacadPattern
{
    public class OwnerProfileFacad : IOwnerProfileFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        private readonly SignInManager<Domain.Entities.Users.User> _signInManager;

        public OwnerProfileFacad(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<Domain.Entities.Users.User> userManager, SignInManager<Domain.Entities.Users.User> signInManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        private IGetIndexOwnerProfileServices _getIndexOwnerProfileServices;
        public IGetIndexOwnerProfileServices GetIndexOwnerProfileServices
        {
            get
            {
                return _getIndexOwnerProfileServices ??= new GetIndexOwnerProfileServices(_context,_httpContext,_userManager);
            }
        }

        
        
        private IGetIndexChangePasswordOwnerProfileServices _getIndexChangePasswordOwnerProfileServices;
        public IGetIndexChangePasswordOwnerProfileServices GetIndexChangePasswordOwnerProfileServices
        {
            get
            {
                return _getIndexChangePasswordOwnerProfileServices ??= new GetIndexChangePasswordOwnerProfileServices(_context,_httpContext,_userManager);
            }
        }
        
        
        
        private IChangePasswordOwnerProfileServices _changePasswordOwnerProfileServices;
        public IChangePasswordOwnerProfileServices ChangePasswordOwnerProfileServices
        {
            get
            {
                return _changePasswordOwnerProfileServices ??= new ChangePasswordOwnerProfileServices(_context,_httpContext,_userManager,_signInManager);
            }
        }


    }
}