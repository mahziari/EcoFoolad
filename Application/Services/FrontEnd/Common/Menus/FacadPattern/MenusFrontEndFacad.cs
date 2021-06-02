using Application.Interfaces.Contexts;
using Microsoft.Extensions.Caching.Distributed;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Common.Menus.Queries;

namespace  Application.Services.FrontEnd.Common.Menus.FacadPattern

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
