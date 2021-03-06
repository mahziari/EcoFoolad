using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Owner.Products.Queries
{
    public interface IGetIndexProductsServices
    {
        ResultGetIndexProductsDto Execute();
    }

    public class GetIndexProductsServices : IGetIndexProductsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexProductsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexProductsDto Execute()
        {
            // var currentUser = AuthorizationService.AuthorizeAsync(U).Result;
            var products = _context.Wsproducts
                // .Where(p=>p.UserId==id)
                // .Where(p=>p.UserId==)
                .Select(p=>new GetIndexProductsDto
                {
                    ProductId = p.ProductId,
                    PrdName=p.PrdName,
                    Price=p.PrdPrice,
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

    public class ResultGetIndexProductsDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
    }


    public class GetIndexProductsDto
    {
        public int ProductId { get; set; }
        public string PrdName { get; set; }
        public decimal? Price { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public GetIndexMenuDto subMenu { get; set; }
    }
    
    public class GetIndexMenuDto
    {
        public string Sgname { get; set; }
    }
}