using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Products.Queries.GetIndexProducts
{
    public class GetIndexProductsServices : IGetIndexProductsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexProductsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexProductsDto Execute()
        {
            var products = _context.Wsproducts
                .Select(p=>new GetIndexProductsDto
                {
                    ProductId = p.ProductId,
                    Price=p.PrdPrice,
                    PrdName=p.PrdName,
                    PrdInactiveInSale=p.PrdInactiveInSale,
                    RegisterDatePersian=p.RegisterDatePersian,
                    subMenu= _context.WsproductSecondGroup
                        .Where(s=> s.PrdSecondGroupId == p.PrdGroupId)
                        .Select(s=>new GetIndexMenuDto{Sgname = s.Sgname})
                        .First(),
                }).OrderByDescending(p=> p.ProductId)
                .ToList();

            return new ResultGetIndexProductsDto
            {
                Products = products,
            };
        }
    }
}