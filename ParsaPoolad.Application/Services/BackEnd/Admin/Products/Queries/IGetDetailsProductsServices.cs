using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Queries
{
    public interface IGetDetailsProductsServices
    {
        ResultGetDetailsProductDto Execute(int id);
    }
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
    
    public class ResultGetDetailsProductDto
    {
        public ResultGeDetailsProductDto Product { get; set; }
    }

    public class ResultGeDetailsProductDto
    {
        public WsproductSecondGroup PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int? PrdMaxQty { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public string RegisterDatePersian { get; set; }
        public decimal? PrdPrice { get; set; }
        public ResultGetDetailsUnitProductDto UnitProducts { get; set; }
        public ResultGetDetailsCompanyProductDto CompanyProducts { get; set; }
    }
    
    public class ResultGetDetailsUnitProductDto
    {
        public string Unit { get; set; }
    }
    public class ResultGetDetailsCompanyProductDto
    {
        public string CmpName { get; set; }
    }
}