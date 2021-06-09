using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Admin;
using  Application.Services.BackEnd.Admin.Products.Commands;
using  Application.Services.BackEnd.Admin.Products.Commands.ActiveProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.CreateProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.DeleteProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.EditProducts;
using  Application.Services.BackEnd.Admin.Products.Queries;
using  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProductsAjax;
using  Application.Services.BackEnd.Admin.Products.Queries.GetDetailsProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetEditProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetIndexProducts;
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Admin.Products.FacadPattern
{
    public class ProductsFacad : IProductsFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;
        private readonly ICustomDbContext _customDbContext;

        public ProductsFacad(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<User> userManager, ICustomDbContext customDbContext)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
            _customDbContext = customDbContext;
        }
        
        private IGetIndexProductsServices _getIndexProductsServices;
        public IGetIndexProductsServices GetIndexProductsServices
        {
            get
            {
                return _getIndexProductsServices ??= new GetIndexProductsServices(_context);
            }
        }
        
        
        private IGetCreateProductServices _getCreateProductServices;
        public IGetCreateProductServices GetCreateProductServices
        {
            get
            {
                return _getCreateProductServices ??= new GetCreateProductServices(_context);
            }
        }
        
        
        private IGetReturnSubMenusAjaxServices _getReturnSubMenusAjaxServices;
        public IGetReturnSubMenusAjaxServices GetReturnSubMenusAjaxServices
        {
            get
            {
                return _getReturnSubMenusAjaxServices ??= new GetReturnSubMenusAjaxServices(_context);
            }
        }
        
        
        
        private IGetReturnSubSubMenusAjaxServices _getReturnSubSubMenusAjaxServices;
        public IGetReturnSubSubMenusAjaxServices GetReturnSubSubMenusAjaxServices
        {
            get
            {
                return _getReturnSubSubMenusAjaxServices ??= new GetReturnSubSubMenusAjaxServices(_context);
            }
        }
        
        
        
        private IGetReturnCompanyAjaxServices _getReturnCompanyAjaxServices;
        public IGetReturnCompanyAjaxServices GetReturnCompanyAjaxServices
        {
            get
            {
                return _getReturnCompanyAjaxServices ??= new GetReturnCompanyAjaxServices(_context);
            }
        }
        
        
        
        
        private ICreateProductsServices _createProductsServices;
        public ICreateProductsServices CreateProductsServices
        {
            get
            {
                return _createProductsServices ??= new CreateProductsServices(_context,_httpContext,_userManager,_customDbContext);
            }
        }
        
        private IGetDetailsProductsServices _getDetailsProductsServices;
        public IGetDetailsProductsServices GetDetailsProductsServices
        {
            get
            {
                return _getDetailsProductsServices ??= new GetDetailsProductsServices(_context);
            }
        }
        
        
        private IGetEditProductServices _getEditProductServices;
        public IGetEditProductServices GetEditProductServices
        {
            get
            {
                return _getEditProductServices ??= new GetEditProductServices(_context);
            }
        }
        
        
        
        private IEditProductsServices _editProductsServices;
        public IEditProductsServices EditProductsServices
        {
            get
            {
                return _editProductsServices ??= new EditProductsServices(_context,_httpContext,_userManager,_customDbContext);
            }
        }
        
        
        private IDeleteProductServices _deleteProductServices;
        public IDeleteProductServices DeleteProductServices
        {
            get
            {
                return _deleteProductServices ??= new DeleteProductServices(_context,_customDbContext);
            }
        }
        
        private IActiveProductServices _activeProductServices;
        public IActiveProductServices ActiveProductServices
        {
            get
            {
                return _activeProductServices ??= new ActiveProductServices(_context,_customDbContext);
            }
        }
        
    }
}