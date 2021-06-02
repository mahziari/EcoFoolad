namespace  Application.Services.BackEnd.Admin.Products.Commands.DeleteProducts
{
    public interface IDeleteProductServices
    {
        ResultDeleteProductDto Execute(int id);
    }
}