using  Application.Services.BackEnd.Admin.Products.Commands.ActiveProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.CreateProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.DeleteProducts;
using  Application.Services.BackEnd.Admin.Products.Commands.EditProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProductsAjax;
using  Application.Services.BackEnd.Admin.Products.Queries.GetDetailsProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetEditProducts;
using  Application.Services.BackEnd.Admin.Products.Queries.GetIndexProducts;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IProductsFacad
    {
        IGetIndexProductsServices GetIndexProductsServices { get; }
        IGetCreateProductServices GetCreateProductServices { get; }
        IGetReturnSubMenusAjaxServices GetReturnSubMenusAjaxServices { get; }
        IGetReturnSubSubMenusAjaxServices GetReturnSubSubMenusAjaxServices { get; }
        IGetReturnCompanyAjaxServices GetReturnCompanyAjaxServices { get; }
        ICreateProductsServices CreateProductsServices { get; }
        IGetDetailsProductsServices GetDetailsProductsServices { get; }
        IGetEditProductServices GetEditProductServices { get; }
        IEditProductsServices EditProductsServices { get; }
        IDeleteProductServices DeleteProductServices { get; }
        IActiveProductServices ActiveProductServices { get; }
    }
}