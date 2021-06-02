 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Products.Commands.ActiveProducts
{
    public class ActiveProductServices : IActiveProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;
        public ActiveProductServices(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }

        public ResultActiveProductDto Execute(int id)
        {
            
            // Active Product to CRM Db
            var product = _context.Wsproducts.Find(id);

            if (product == null)
            {
                return new ResultActiveProductDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            if (product.PrdInactiveInSale == false)
            {
                product.PrdInactiveInSale = true;  
            }
            else if(product.PrdInactiveInSale == true)
            {
                product.PrdInactiveInSale = false;
            }
            _context.SaveChanges();
            
            
            
            // Active Product to CustomDbContext Db
            var productCustomDbContext = _customDbContext.Products.Find(id);

            if (productCustomDbContext == null)
            {
                return new ResultActiveProductDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            if (productCustomDbContext.PrdInactiveInSale == false)
            {
                productCustomDbContext.PrdInactiveInSale = true;  
            }
            else if(productCustomDbContext.PrdInactiveInSale == true)
            {
                productCustomDbContext.PrdInactiveInSale = false;
            }
            _customDbContext.SaveChanges();

            

            return new ResultActiveProductDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }
}