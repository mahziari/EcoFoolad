using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Owner;
using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Commands;
using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries;
using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries.GetCreateProductsAjax;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Products.FacadPattern
{
    public class OwnerProductsFacad : IOwnerProductsFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;

        public OwnerProductsFacad(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<User> userManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
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
                return _createProductsServices ??= new CreateProductsServices(_context,_httpContext,_userManager);
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
                return _editProductsServices ??= new EditProductsServices(_context);
            }
        }
        
        
        private IDeleteProductServices _deleteProductServices;
        public IDeleteProductServices DeleteProductServices
        {
            get
            {
                return _deleteProductServices ??= new DeleteProductServices(_context);
            }
        }
        
        private IActiveProductServices _activeProductServices;
        public IActiveProductServices ActiveProductServices
        {
            get
            {
                return _activeProductServices ??= new ActiveProductServices(_context);
            }
        }
        
    }
}