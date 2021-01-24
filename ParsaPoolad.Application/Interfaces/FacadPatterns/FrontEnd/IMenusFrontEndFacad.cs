using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IMenusFrontEndFacad
    {
        IGetMenusFrontEndService GetMenusFrontEndService { get; }
    }
}
