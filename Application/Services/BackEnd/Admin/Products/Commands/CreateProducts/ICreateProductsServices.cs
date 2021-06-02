namespace  Application.Services.BackEnd.Admin.Products.Commands.CreateProducts
{
    public interface ICreateProductsServices
    {
        ResultCreateProductsDto Execute(CreateProductsServicesDto createProductsServicesDto);
    }
}