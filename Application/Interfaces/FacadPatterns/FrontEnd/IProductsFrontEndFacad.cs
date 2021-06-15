using  Application.Services.FrontEnd.Products.Queries;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IProductsFrontEndFacad
    {
        IGetProductsFrontEndService GetProductsFrontEndService { get; }
        IGetProductsDetailsFrontEndService GetProductsDetailsFrontEndService { get; }
        IGetProductsCategoryFrontEndService GetProductsCategoryThirdGroupFrontEndService { get; }
        IGetProductsCategoryFrontEndService GetProductsCategoryFirstGroupFrontEndService { get; }
        IGetProductsCategoryFrontEndService GetProductsSecoundGroupNameFrontEndService { get; }

    }
}