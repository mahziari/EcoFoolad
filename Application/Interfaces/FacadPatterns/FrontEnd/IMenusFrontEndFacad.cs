using  Application.Services.FrontEnd.Common.Menus.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IMenusFrontEndFacad
    {
        IGetMenusFrontEndService GetMenusFrontEndService { get; }
    }
}
