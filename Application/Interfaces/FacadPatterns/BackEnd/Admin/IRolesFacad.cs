using  Application.Services.BackEnd.Admin.BlogsCategories.Queries;
using  Application.Services.BackEnd.Admin.Roles.Queries;
using  Application.Services.BackEnd.Admin.Roles.Commands;
using  Application.Services.BackEnd.Admin.Roles.Commands.CreateRoles;
using  Application.Services.BackEnd.Admin.Roles.Commands.EditRoles;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
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