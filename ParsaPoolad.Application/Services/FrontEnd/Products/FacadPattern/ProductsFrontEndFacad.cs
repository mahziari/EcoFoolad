using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Products.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Products.FacadPattern
{
    public class ProductsFrontEndFacad: IProductsFrontEndFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _parsapooladContext;

        public ProductsFrontEndFacad(IIdealCrmDataBaseContext context,ICustomDbContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }
        
        private IGetProductsFrontEndService _getProductsFrontEndService;
        public IGetProductsFrontEndService GetProductsFrontEndService
        {
            get
            {
                return _getProductsFrontEndService ??= new GetProductsFrontEndService(_context,_parsapooladContext);
            }
        }
        
        
        private IGetProductsDetailsFrontEndService _getProductsDetailsFrontEndService;
                 public IGetProductsDetailsFrontEndService GetProductsDetailsFrontEndService
                 {
                     get
                     {
                         return _getProductsDetailsFrontEndService ??= new GetProductsDetailsFrontEndService(_context);
                     }
                 }
        
        
        
        private IGetProductsCategoryFrontEndService _getProductsCategoryFrontEndService;
        public IGetProductsCategoryFrontEndService GetProductsCategoryFrontEndService
        {
            get
            {
                return _getProductsCategoryFrontEndService ??= new GetProductsCategoryFrontEndService(_context);
            }
        }
    }
}