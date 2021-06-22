using Application.Services.FrontEnd.Common.Footers.Queries;

namespace Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IFootersFrontEndFacad
    {
        IGetFootersFrontEndService GetFootersFrontEndService { get; }
    }
}