using  Application.Services.BackEnd.Owner.Products.Commands;
using  Application.Services.BackEnd.Owner.Products.Queries;
using  Application.Services.BackEnd.Owner.Products.Queries.GetCreateProductsAjax;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Owner
{
    public interface IOwnerProductsFacad
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