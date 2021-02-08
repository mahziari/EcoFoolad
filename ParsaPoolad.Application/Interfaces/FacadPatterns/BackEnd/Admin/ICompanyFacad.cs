using ParsaPoolad.Application.Services.BackEnd.Admin.Company.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.Company.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface ICompanyFacad
    {
        
        IGetIndexCompanyServices GetIndexCompanyServices { get; }
        IGetCreateCompanyServices GetCreateCompanyServices { get; }
        ICreateCompanyServices CreateCompanyServices { get; }
        IGetDetailsCompanyServices GetDetailsCompanyServices { get; }
        IGetEditCompanyServices GetEditCompanyServices { get; }
        IEditCompanyServices EditCompanyServices { get; }
        IDeleteCompanyServices DeleteCompanyServices { get; }
        IActiveCompanyServices ActiveCompanyServices { get; }

    }
}