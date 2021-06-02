using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Blogs.Queries;
using Application.Services.FrontEnd.Fainances.Commands;
using Application.Services.FrontEnd.Fainances.Queries;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace  Application.Services.FrontEnd.Fainances.FacadPattern
{
    public class FinancesFrontEndFacad: IFinancesFrontEndFacad
    {
        private readonly ICustomDbContext _context;
        private readonly UserManager<User> _userManager;

        public FinancesFrontEndFacad(ICustomDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        private IAddRequestPayService _addRequestPayService;
        public IAddRequestPayService AddRequestPayService
        {
            get
            {
                return _addRequestPayService ??= new AddRequestPayService(_context,_userManager);
            }
        }
        
        
        private IGetRequestPayService _getRequestPayService;
        public IGetRequestPayService GetRequestPayService
        {
            get
            {
                return _getRequestPayService ??= new GetRequestPayService(_context);
            }
        }
        
    }
}