using  Application.Services.BackEnd.Admin.Menus.Commands;
using  Application.Services.BackEnd.Admin.Menus.Queries;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IMenusFacad
    {
        IGetMenusService GetMenusService { get; }
        IGetEditMenusService GetEditMenusService { get; }
        IGetEditSubMenusService GetEditSubMenusService { get; }
        
        ICreateNewMenusServices CreateNewMenusServices { get; }
        ICreateNewSubMenusServices CreateNewSubMenusServices { get; }
        
        IEditMenusServices EditMenusServices { get; }
        IEditSubMenusServices EditSubMenusServices { get; }
        
        IRemoveMenusServices RemoveMenusServices { get; }
        IRemoveSubMenusServices RemoveSubMenusServices { get; }
    }
}
