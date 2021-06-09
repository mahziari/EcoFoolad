 

using System.Linq;
using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Products.Commands.DeleteProducts
{
    public class DeleteProductServices : IDeleteProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;
        public DeleteProductServices(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }

        public ResultDeleteProductDto Execute(int id)
        {
            var crmProduct = _context.Wsproducts.Find(id);
            var product = _customDbContext.Products.First(p => p.PrdCrmId==id);

            if (product == null)
            {
                return new ResultDeleteProductDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            _context.Wsproducts.Remove(crmProduct);
            _context.SaveChanges();
            
            _customDbContext.Products.Remove(product);
            _customDbContext.SaveChanges();

            return new ResultDeleteProductDto()
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}