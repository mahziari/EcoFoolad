using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsCategoryFrontEndService
    {
        ResultGetProductsCategoryFrontEndDto Execute(string menuName,int pageNumber);
    }

    public class GetProductsCategoryFrontEndService: IGetProductsCategoryFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetProductsCategoryFrontEndService(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetProductsCategoryFrontEndDto Execute(string menuName,int pageNumber)
        {
            
            var secondGroup = _context.WsproductSecondGroup
                .Where(s => s.Sgname == menuName.Replace("-"," "))
                .FirstOrDefault();
            
            var firstGroup = _context.WsproductFirstGroup
                .Where(s => s.PrdFirstGroupId ==secondGroup.FirstGroupId)
                .Select(s=>s.ParsaPooladMenusId)
                .FirstOrDefault();
            
            var parsapooladMenu = _context.ParsaPooladMenus
                .FirstOrDefault(s => s.ParsaPooladMenusId ==firstGroup);
            
            
            // Paginate Code
            var resultInEachPage = 1;
            int skip = (pageNumber - 1) * resultInEachPage;
            int count = _context.Wsproducts
                .Where(p=>p.PrdGroupId==secondGroup.PrdSecondGroupId)
                .Count(p => p.PrdInactiveInSale==true);
            var pageId = pageNumber;
            var pageCount = (int)Math.Ceiling(count / (double)resultInEachPage);
            // Paginate Code
            
            
            var products = _context.Wsproducts
                .OrderByDescending(p=> p.ProductId)
                .Where(p=>p.PrdGroupId==secondGroup.PrdSecondGroupId)
                .Where(p=>p.PrdInactiveInSale==true)
                .Select(p=>new GetIndexProductsDto
                {
                    ProductId = p.ProductId,
                    PrdName=p.PrdName,
                    UrlName=parsapooladMenu.UrlName,
                    PrdInactiveInSale=p.PrdInactiveInSale,
                    RegisterDatePersian=p.RegisterDatePersian,
                }).Skip(skip).Take(resultInEachPage).ToList();

            return new ResultGetProductsCategoryFrontEndDto
            {
                Products = products,
                PageId =pageId,
                PageCount =pageCount,
            };
        }
    }

    public class ResultGetProductsCategoryFrontEndDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
    }


    public class GetIndexProductsDto
    {
        public int ProductId { get; set; }
        public string PrdName { get; set; }
        public string UrlName { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public GetIndexMenuDto subMenu { get; set; }
    }
    
    public class GetIndexMenuDto
    {
        public string Sgname { get; set; }
    }
}