using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Commands;
using ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Queries;


namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.FacadPattern
{
    public class MenusFacad : IMenusFacad
    {
        private readonly IDataBaseContext _context;

        public MenusFacad(IDataBaseContext context)
        {
            _context = context;
        }
        
        
        private IGetMenusService _getMenusService;
        public IGetMenusService GetMenusService
        {
            get
            {
                return _getMenusService ??= new GetMenusService(_context);
            }
        }
        
        
        private IGetEditMenusService _getEditMenusService;
        public IGetEditMenusService GetEditMenusService
        {
            get
            {
                return _getEditMenusService ??= new GetEditMenusService(_context);
            }
        }
        
        
        
        private IGetEditSubMenusService _getEditSubMenusService;
        public IGetEditSubMenusService GetEditSubMenusService
        {
            get
            {
                return _getEditSubMenusService ??= new GetEditSubMenusService(_context);
            }
        }
        
        
        private ICreateNewMenusServices _createNewMenusServices;
        public ICreateNewMenusServices CreateNewMenusServices
        {
            get
            {
                return _createNewMenusServices ??= new CreateNewMenusServices(_context);
            }
        }
        
        
        private ICreateNewSubMenusServices _createNewSubMenusServices;
        public ICreateNewSubMenusServices CreateNewSubMenusServices
        {
            get
            {
                return _createNewSubMenusServices ??= new CreateNewSubMenusServices(_context);
            }
        }

        private IEditMenusServices _editMenusServices;

        public IEditMenusServices EditMenusServices
        {
            get
            {
                return _editMenusServices ??= new EditMenusServices(_context);

            }
        }



        private IEditSubMenusServices _editSubMenusServices;

        public IEditSubMenusServices EditSubMenusServices
        {
            get
            {
                return _editSubMenusServices ??= new EditSubMenusServices(_context);
            }
        }



        private IRemoveMenusServices _removeMenusServices;

        public IRemoveMenusServices RemoveMenusServices
        {
            get
            {
                return _removeMenusServices ??= new RemoveMenusServices(_context);
            }
        }



        private IRemoveSubMenusServices _removeSubMenusServices;

        public IRemoveSubMenusServices RemoveSubMenusServices
        {
            get
            {
                return _removeSubMenusServices ??= new RemoveSubMenusServices(_context);
            }
        }
    }
}
