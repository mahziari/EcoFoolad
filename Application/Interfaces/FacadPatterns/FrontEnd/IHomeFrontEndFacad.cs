using  Application.Services.FrontEnd.Home.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IHomeFrontEndFacad
    {
        IGetHomeFrontEndService GetHomeFrontEndService { get; }

    }
}