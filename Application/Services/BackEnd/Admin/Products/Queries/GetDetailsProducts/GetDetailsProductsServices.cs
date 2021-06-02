﻿using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Products.Queries.GetDetailsProducts
{
    public class GetDetailsProductsServices : IGetDetailsProductsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetDetailsProductsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetDetailsProductDto Execute(int id)
        {
            var product = _context.Wsproducts
                .Where(f => f.ProductId == id)
                .Select(f => new ResultGeDetailsProductDto
                {
                    PrdGroupId =_context.WsproductSecondGroup.First(s => s.PrdSecondGroupId == f.PrdGroupId),
                    PrdCode = f.PrdCode,
                    PrdName = f.PrdName,
                    PrdSize = f.PrdSize,
                    UnitProducts = _context.WsproductUnits
                        .Where(u=> u.ProductUnitId == f.PrdUnitId)
                        .Select(u=>new ResultGetDetailsUnitProductDto{ Unit=u.Unit})
                        .First(),
                    PrdMaxQty = f.PrdMaxQty,
                    PrdDescription = f.PrdDescription,
                    PrdModel = f.PrdModel,
                    CompanyProducts = _context.CrmCompany
                        .Where(c=> c.CompanyId==f.PrdShpotherSupplierId)
                        .Select(c=> new ResultGetDetailsCompanyProductDto{ CmpName=c.CmpName })
                        .First(),
                    RegisterDatePersian = f.RegisterDatePersian,
                    PrdPrice = f.PrdPrice,
                }).FirstOrDefault();
            return new ResultGetDetailsProductDto
            {
                Product=product,
            };
        }
    }
}