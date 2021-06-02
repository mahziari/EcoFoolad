namespace  Application.Services.BackEnd.Admin.Roles.Commands.EditRoles
{
    public interface IEditRolesServices
    {
        ResultEditRolesDto Execute(EditRolesServicesDto editRolesServicesDto, string id);
    }
}