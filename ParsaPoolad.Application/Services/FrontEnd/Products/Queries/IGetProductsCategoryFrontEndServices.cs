using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsCategoryFrontEndService
    {
        ResultGetProductsCategoryFrontEndDto Execute(string subMenu,int page);
    }

    public class GetProductsCategoryFrontEndService: IGetProductsCategoryFrontEndService
    {
        private readonly IDataBaseContext _context;

        public GetProductsCategoryFrontEndService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetProductsCategoryFrontEndDto Execute(string subMenu,int page)
        {
            
            var products = _context.Wsproducts
                .OrderByDescending(p=> p.ProductId)
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
                }).ToList();

            return new ResultGetProductsCategoryFrontEndDto
            {
                Products = products
            };
        }
    }

    public class ResultGetProductsCategoryFrontEndDto
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