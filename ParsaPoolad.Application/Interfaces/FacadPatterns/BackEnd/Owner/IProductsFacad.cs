using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Commands;
using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries;
using ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries.GetCreateProductsAjax;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Owner
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