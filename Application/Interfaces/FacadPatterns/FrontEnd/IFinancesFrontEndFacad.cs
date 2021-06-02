using Application.Services.FrontEnd.Fainances.Commands;
using Application.Services.FrontEnd.Fainances.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IFinancesFrontEndFacad
    {
        IAddRequestPayService AddRequestPayService { get; }
        IGetRequestPayService GetRequestPayService { get; }

    }
}