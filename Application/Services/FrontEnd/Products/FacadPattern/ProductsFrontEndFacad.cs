using Application.Interfaces.Contexts;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Products.Queries;
using AutoMapper;

namespace  Application.Services.FrontEnd.Products.FacadPattern
{
    public class ProductsFrontEndFacad: IProductsFrontEndFacad
    {
        private readonly IIdealCrmDataBaseContext _idealCrmDataBase;
        private readonly ICustomDbContext _parsapooladContext;
        private readonly IMapper _mapper;

        public ProductsFrontEndFacad(IIdealCrmDataBaseContext idealCrmDataBase,ICustomDbContext parsapooladContext, IMapper mapper)
        {
            _idealCrmDataBase = idealCrmDataBase;
            _parsapooladContext = parsapooladContext;
            _mapper = mapper;
        }
        
        private IGetProductsFrontEndService _getProductsFrontEndService;
        public IGetProductsFrontEndService GetProductsFrontEndService
        {
            get
            {
                return _getProductsFrontEndService ??= new GetProductsFrontEndService(_idealCrmDataBase,_parsapooladContext);
            }
        }
        
        
        private IGetProductsDetailsFrontEndService _getProductsDetailsFrontEndService;
                 public IGetProductsDetailsFrontEndService GetProductsDetailsFrontEndService
                 {
                     get
                     {
                         return _getProductsDetailsFrontEndService ??= new GetProductsDetailsFrontEndService(_idealCrmDataBase);
                     }
                 }
        
        
        
        private IGetProductsCategoryFrontEndService _getProductsCategoryFrontEndService;
        public IGetProductsCategoryFrontEndService GetProductsCategoryFrontEndService
        {
            get
            {
                return _getProductsCategoryFrontEndService ??= new GetProductsCategoryFrontEndService(_idealCrmDataBase,_parsapooladContext,_mapper);
            }
        }
    }
}