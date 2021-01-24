using ParsaPoolad.Application.Services.FrontEnd.Home.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IHomeFrontEndFacad
    {
        IGetHomeFrontEndService GetHomeFrontEndService { get; }

    }
}