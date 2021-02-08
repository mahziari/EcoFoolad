using ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Queries;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Commands;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IRolesFacad
    {
        IGetIndexRolesServices GetIndexRolesServices { get; }
        IGetCreateRolesServices GetCreateRolesServices { get; }
        ICreateRolesServices CreateRolesServices { get; }
        IGetEditRolesServices GetEditRolesServices { get; }
        IEditRolesServices EditRolesServices { get; }
    }
}