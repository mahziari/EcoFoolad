using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Company.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.Company.Queries;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Company.FacadPattern
{
    public class CompanyFacad : ICompanyFacad
    {
        
        private readonly IIdealCrmDataBaseContext _context;

        public CompanyFacad(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }
        
        
        private IGetIndexCompanyServices _getIndexCompanyServices;
        public IGetIndexCompanyServices GetIndexCompanyServices
        {
            get
            {
                return _getIndexCompanyServices ??= new GetIndexCompanyServices(_context);
            }
        }
        
        
        
        private IGetCreateCompanyServices _getCreateCompanyServices;
        public IGetCreateCompanyServices GetCreateCompanyServices
        {
            get
            {
                return _getCreateCompanyServices ??= new GetCreateCompanyServices(_context);
            }
        }
        
        
        private ICreateCompanyServices _createCompanyServices;
        public ICreateCompanyServices CreateCompanyServices
        {
            get
            {
                return _createCompanyServices ??= new CreateCompanyServices(_context);
            }
        }
        
        
        private IGetDetailsCompanyServices _getDetailsCompanyServices;
        public IGetDetailsCompanyServices GetDetailsCompanyServices
        {
            get
            {
                return _getDetailsCompanyServices ??= new GetDetailsCompanyServices(_context);
            }
        }
        
        
        private IGetEditCompanyServices _getEditCompanyServices;
        public IGetEditCompanyServices GetEditCompanyServices
        {
            get
            {
                return _getEditCompanyServices ??= new GetEditCompanyServices(_context);
            }
        }
        
        
        
        private IEditCompanyServices _editCompanyServices;
        public IEditCompanyServices EditCompanyServices
        {
            get
            {
                return _editCompanyServices ??= new EditCompanyServices(_context);
            }
        }
        
        
        private IDeleteCompanyServices _deleteCompanyServices;
        public IDeleteCompanyServices DeleteCompanyServices
        {
            get
            {
                return _deleteCompanyServices ??= new DeleteCompanyServices(_context);
            }
        }
        
        
        
        private IActiveCompanyServices _activeCompanyServices;
        public IActiveCompanyServices ActiveCompanyServices
        {
            get
            {
                return _activeCompanyServices ??= new ActiveCompanyServices(_context);
            }
        }
    }
}