using Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto;

namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory
{
    public interface IGetProductsCategoryFrontEndService
    {
        ResultGetProductsCategoryFrontEndDto Execute(ProductsFiltersDto productsFiltersDto);
    }
}