using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Products.Queries.GetEditProducts
{
    public class GetEditProductServices : IGetEditProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditProductsDto Execute(int id)
        {
            var product = _context.Wsproducts
                .Include(p=>p.PrdGroup)
                .Include(p => p.PrdUnit)
                .Include(p => p.PrdShpotherSupplier)
                .FirstOrDefault(p => p.ProductId==id);

            var subMenus = _context.WsproductFirstGroup
                .FirstOrDefault(s => s.PrdFirstGroupId == product.PrdGroup.FirstGroupId);
            
            var sMenus = _context.ParsaPooladMenus
                .FirstOrDefault(s => s.ParsaPooladMenusId == subMenus.ParsaPooladMenusId );
            
            
            var menus = _context.ParsaPooladMenus
                .Select(s=>new GetEditMenusDto
                {
                    ParsaPooladMenusId=s.ParsaPooladMenusId,
                    Name = s.Name
                }).ToList();

            var company = _context.CrmCompany
                .Select(c => new GetEditCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName
                }).ToList();
            
            var productsUnit = _context.WsproductUnits
                .Select(c => new GetEditProductsUnitDto
                {
                    ProductUnitId=c.ProductUnitId,
                    Unit=c.Unit
                }).ToList();

            return new ResultGetEditProductsDto
            {
                Product=product,
                SubMenus=subMenus,
                SMenus=sMenus,
                Menus = menus,
                Company = company,
                ProductsUnit = productsUnit,
            };
        }

        
    }
}