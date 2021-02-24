using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries
{
    public interface IGetIndexProductsServices
    {
        ResultGetIndexProductsDto Execute();
    }

    public class GetIndexProductsServices : IGetIndexProductsServices
    {
        private readonly IDataBaseContext _context;

        public GetIndexProductsServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexProductsDto Execute()
        {
            var products = _context.Wsproducts
                .Select(p=>new GetIndexProductsDto
                {
                    ProductId = p.ProductId,
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

    public class ResultGetIndexProductsDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
    }


    public class GetIndexProductsDto
    {
        public int ProductId { get; set; }
        public string PrdName { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public GetIndexMenuDto subMenu { get; set; }
    }
    
    public class GetIndexMenuDto
    {
        public string Sgname { get; set; }
    }
}