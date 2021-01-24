using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsFrontEndService
    {
        ResultGetProductsFrontEndDto Execute();
    }

    public class GetProductsFrontEndService : IGetProductsFrontEndService
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public GetProductsFrontEndService(IDataBaseContext context, IIdentityDataBaseContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }


        public ResultGetProductsFrontEndDto Execute()
        {
            var products = _context.Wsproducts
                // .Where(s => s.PrdInactiveInSale = true)
                .Select(s => new GetProductsDto
                {
                    ProductId = s.ProductId,
                    PrdGroupId = s.PrdGroupId,
                    PrdCode = s.PrdCode,
                    PrdName = s.PrdName,
                    PrdSize = s.PrdSize,
                    PrdUnitId = s.PrdUnitId,
                    PrdMaxQty = s.PrdMaxQty,
                    RegisterDatePersian = s.RegisterDatePersian,
                    PrdModel = s.PrdModel,
                    PrdPrice = s.PrdPrice
                }).ToList();


            return new ResultGetProductsFrontEndDto
            {
                Products = products,
            };
        }
    }

    public class ResultGetProductsFrontEndDto
    {
        public List<GetProductsDto> Products { get; set; }
    }


    public class GetProductsDto
    {
        public int ProductId { get; set; }
        public int PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int? PrdUnitId { get; set; }
        public int? PrdMaxQty { get; set; }
        public string RegisterDatePersian { get; set; }
        public string PrdModel { get; set; }
        public int PrdShpotherSupplierId { get; set; }
        public decimal? PrdPrice { get; set; }
    }
}