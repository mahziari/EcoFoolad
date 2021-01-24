using System;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Commands
{
    public interface ICreateProductsServices
    {
        ResultCreateProductsDto Execute(Wsproducts wsproducts);
    }

    public class CreateProductsServices:ICreateProductsServices {
        private readonly IDataBaseContext _context;

        public CreateProductsServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateProductsDto Execute(Wsproducts wsproducts)
        {
            Wsproducts product = new Wsproducts()
            {
                PrdGroupId = wsproducts.PrdGroupId ,
                PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}",
                PrdName = wsproducts.PrdName ,
                PrdShpotherSupplierId = wsproducts.PrdShpotherSupplierId ,
                PrdUnitId = wsproducts.PrdUnitId,
                PrdMaxQty = wsproducts.PrdMaxQty,
                PrdSize = wsproducts.PrdSize,
                PrdModel = wsproducts.PrdModel,
                PrdDescription = wsproducts.PrdDescription,
                PrdPrice =wsproducts.PrdPrice,
                PrdInactiveInSale =true,
                UserId= 57,
                Month1=6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
            };
            
            _context.Wsproducts.Add(product);
            _context.SaveChanges();

            return new ResultCreateProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت اضافه شد"
            };
        }

    }

    public class ResultCreateProductsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}