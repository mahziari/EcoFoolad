 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Owner.Products.Commands
{
    public interface IActiveProductServices
    {
        ResultActiveProductDto Execute(int id);
    }
    public class ActiveProductServices : IActiveProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public ActiveProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultActiveProductDto Execute(int id)
        {
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

            return new ResultActiveProductDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }

    public class ResultActiveProductDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}