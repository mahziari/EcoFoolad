using ParsaPoolad.Application.Services.FrontEnd.Products.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IProductsFrontEndFacad
    {
        IGetProductsFrontEndService GetProductsFrontEndService { get; }
        IGetProductsDetailsFrontEndService GetProductsDetailsFrontEndService { get; }
        IGetProductsCategoryFrontEndService GetProductsCategoryFrontEndService { get; }

    }
}