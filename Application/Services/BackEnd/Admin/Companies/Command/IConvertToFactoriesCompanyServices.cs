using Application.Interfaces.Contexts;

namespace Application.Services.BackEnd.Admin.Company.Command
{
    public interface IConvertToFactoriesCompanyServices
    {
        ResultConvertToFactoriesCompanyDto Execute(int id);
    }
    
    public class ConvertToFactoriesCompanyServices : IConvertToFactoriesCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public ConvertToFactoriesCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultConvertToFactoriesCompanyDto Execute(int id)
        {
            var company = _context.CrmCompany.Find(id);

            if (company == null)
            {
                return new ResultConvertToFactoriesCompanyDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            if (company.IsFactory == false)
            {
                company.IsFactory = true;  
            }
            else if(company.IsFactory == true)
            {
                company.IsFactory = false;
            }
            _context.SaveChanges();

            return new ResultConvertToFactoriesCompanyDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }

    public class ResultConvertToFactoriesCompanyDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}