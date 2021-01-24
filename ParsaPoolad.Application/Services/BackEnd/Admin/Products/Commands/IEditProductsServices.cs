using System;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Commands
{
    public interface IEditProductsServices
    {
        ResultEditProductsDto Execute(Wsproducts wsproducts,int id);
    }

    public class EditProductsServices:IEditProductsServices {
        private readonly IDataBaseContext _context;

        public EditProductsServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultEditProductsDto Execute(Wsproducts wsproducts,int id)
        {
            var product = _context.Wsproducts.Find(id);

            product.PrdGroupId = wsproducts.PrdGroupId;
            product.PrdCode = $"{(DateTime.Now.Ticks / 10) % 1000000000:d9}";
            product.PrdName = wsproducts.PrdName;
            product.PrdShpotherSupplierId = wsproducts.PrdShpotherSupplierId;
            product.PrdUnitId = wsproducts.PrdUnitId;
            product.PrdMaxQty = wsproducts.PrdMaxQty;
            product.PrdSize = wsproducts.PrdSize;
            product.PrdModel = wsproducts.PrdModel;
            product.PrdDescription = wsproducts.PrdDescription;
            product.PrdPrice = wsproducts.PrdPrice;
            _context.SaveChanges();

            return new ResultEditProductsDto
            {
                IsSuccess = true,
                Message = "محصول با موفقیت ویرایش شد"
            };
        }

    }

    public class ResultEditProductsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}