using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Domain.Entities.IdealCrm;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsDetailsFrontEndService
    {
        ResultGetProductsDetailsFrontEndDto Execute(string prdName);
    }

    public class GetProductsDetailsFrontEndService: IGetProductsDetailsFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;
        public GetProductsDetailsFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }



        public ResultGetProductsDetailsFrontEndDto Execute(string prdName)
        {
            var product = _context.Wsproducts
                .Include(p=>p.PrdGroup)
                .ThenInclude(p=>p.FirstGroup)
                .ThenInclude(p=>p.ParsaPooladMenus)
                .Single(p => p.PrdName == prdName.Replace("-"," "));
            product.VisitCount += 1;
            _context.SaveChanges();


           var customProduct= _customDbContext.Products.Single(p => p.PrdCrmId == product.ProductId);
           customProduct.VisitCount += 1;
           _customDbContext.SaveChanges();

            return new ResultGetProductsDetailsFrontEndDto
            {
                Product = product,
            };
        }
    }

    public class ResultGetProductsDetailsFrontEndDto
    {
        public Wsproducts Product { get; set; }
    }


    public class GetProductsDetailsDto
    {
        public int ProductId { get; set; }
        public string PrdName { get; set; }
        public string UrlName { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime DateTime { get; set; }
        public string PrdUnit { get; set; }
        public int? PrdMaxQty { get; set; }
        public string PrdSize { get; set; }
        public string PrdModel { get; set; }
        public decimal? PrdPrice { get; set; }
        public string PrdDescription { get; set; }
    }
}