using Application.Interfaces.Contexts;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Products.Queries;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory;
using AutoMapper;

namespace  Application.Services.FrontEnd.Products.FacadPattern
{
    public class ProductsFrontEndFacad: IProductsFrontEndFacad
    {
        private readonly IIdealCrmDataBaseContext _idealCrmDataBase;
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public ProductsFrontEndFacad(IIdealCrmDataBaseContext idealCrmDataBase,ICustomDbContext customDbContext, IMapper mapper)
        {
            _idealCrmDataBase = idealCrmDataBase;
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        private IGetProductsFrontEndService _getProductsFrontEndService;
        public IGetProductsFrontEndService GetProductsFrontEndService
        {
            get
            {
                return _getProductsFrontEndService ??= new GetProductsFrontEndService(_idealCrmDataBase,_customDbContext);
            }
        }
        
        
        private IGetProductsDetailsFrontEndService _getProductsDetailsFrontEndService;
                 public IGetProductsDetailsFrontEndService GetProductsDetailsFrontEndService
                 {
                     get
                     {
                         return _getProductsDetailsFrontEndService ??= new GetProductsDetailsFrontEndService(_idealCrmDataBase,_customDbContext);
                     }
                 }
        
                 
        
        
        private IGetProductsCategoryFrontEndService _getProductsCategoryFrontEndService;
        public IGetProductsCategoryFrontEndService GetProductsCategoryFrontEndService
        {
            get
            {
                return _getProductsCategoryFrontEndService ??= new GetProductsCategoryFrontEndService(_idealCrmDataBase,_customDbContext,_mapper);
            }
        }
        
        
        private IGetProductsCategoryFrontEndService _getProductsCategoryFirstGroupFrontEndService;
        public IGetProductsCategoryFrontEndService GetProductsCategoryFirstGroupFrontEndService
        {
            get
            {
                return _getProductsCategoryFirstGroupFrontEndService ??= new GetProductsCategoryFirstGroupFrontEndService(_idealCrmDataBase,_customDbContext,_mapper);
            }
        }
        
        
        private IGetProductsCategoryFrontEndService _getProductsSecoundGroupNameFrontEndService;
        public IGetProductsCategoryFrontEndService GetProductsSecoundGroupNameFrontEndService
        {
            get
            {
                return _getProductsSecoundGroupNameFrontEndService ??= new GetProductsSecoundGroupNameFrontEndService(_idealCrmDataBase,_customDbContext,_mapper);
            }
        }
    }
}