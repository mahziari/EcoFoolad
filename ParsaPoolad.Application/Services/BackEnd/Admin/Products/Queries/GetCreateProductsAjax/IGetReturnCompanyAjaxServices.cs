using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Products.Queries.GetCreateProductsAjax
{
    public interface IGetReturnCompanyAjaxServices
    {
        ResultAjaxReturnCompanyMenuDto Execute(int id);
    }


    public class GetReturnCompanyAjaxServices : IGetReturnCompanyAjaxServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetReturnCompanyAjaxServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultAjaxReturnCompanyMenuDto Execute(int id)
        {

            var companyMenus = _context.CrmCompany
                .Where(c => c.ParsaPooladMenusId == id)
                .Select(c => new AjaxReturnCompanyDto
                {
                    CompanyId = c.CompanyId,
                    CmpName = c.CmpName
                }).ToList();

            return new ResultAjaxReturnCompanyMenuDto
            {
                CompanyMenus = companyMenus,
            };
        }
    }

    public class ResultAjaxReturnCompanyMenuDto
    {
        public List<AjaxReturnCompanyDto> CompanyMenus { get; set; }
    }
    
    
    public class AjaxReturnCompanyDto
    {
        public int CompanyId { get; set; }
        public string CmpName { get; set; }
    }

}