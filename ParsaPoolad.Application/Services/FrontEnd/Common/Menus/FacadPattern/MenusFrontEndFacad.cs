using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Common.Menus.FacadPattern

{
    public class MenusFrontEndFacad : IMenusFrontEndFacad
    {
        private readonly IDataBaseContext _context;

        public MenusFrontEndFacad(IDataBaseContext context)
        {
            _context = context;
        }
        
        
        private IGetMenusFrontEndService _getMenusFrontEndService;
        public IGetMenusFrontEndService GetMenusFrontEndService
        {
            get
            {
                return _getMenusFrontEndService ??= new GetMenusFrontEndService(_context);
            }
        }
        
      
    }
}
