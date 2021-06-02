 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Products.Commands.DeleteProducts
{
    public class DeleteProductServices : IDeleteProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public DeleteProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteProductDto Execute(int id)
        {
            var product = _context.Wsproducts.Find(id);

            if (product == null)
            {
                return new ResultDeleteProductDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            _context.Wsproducts.Remove(product);
            _context.SaveChanges();

            return new ResultDeleteProductDto()
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}