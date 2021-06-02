namespace  Application.Services.BackEnd.Admin.Roles.Commands.CreateRoles
{
    public interface ICreateRolesServices
    {
        ResultCreateRolesDto Execute(CreateRolesServicesDto createRolesServicesDto);
    }
}