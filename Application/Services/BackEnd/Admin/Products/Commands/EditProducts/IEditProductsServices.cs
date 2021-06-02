namespace  Application.Services.BackEnd.Admin.Products.Commands.EditProducts
{
    public interface IEditProductsServices
    {
        ResultEditProductsDto Execute(EditProductsServicesDto editProductsServicesDto,int id);
    }
}