using  Application.Services.BackEnd.Admin.Company.Command;
using  Application.Services.BackEnd.Admin.Company.Queries;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
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