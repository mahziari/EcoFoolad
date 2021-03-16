using Microsoft.Extensions.Caching.Distributed;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Common.Menus.FacadPattern

{
    public class MenusFrontEndFacad : IMenusFrontEndFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IDistributedCache cache;
        public MenusFrontEndFacad(IIdealCrmDataBaseContext context, IDistributedCache cache)
        {
            _context = context;
            this.cache = cache;
        }
        
        
        private IGetMenusFrontEndService _getMenusFrontEndService;
        public IGetMenusFrontEndService GetMenusFrontEndService
        {
            get
            {
                return _getMenusFrontEndService ??= new GetMenusFrontEndService(_context,cache);
            }
        }
        
      
    }
}
