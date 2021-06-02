using  Application.Services.BackEnd.Admin.Sliders.Commands;
using  Application.Services.BackEnd.Admin.Sliders.Queries;
using IGetCreateSlidersServices =  Application.Services.BackEnd.Admin.Sliders.Queries.IGetCreateSlidersServices;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface ISlidersFacad
    {
        
        IGetIndexSlidersServices GetIndexSlidersServices { get; }
        IGetCreateSlidersServices GetCreateSlidersServices { get; }
        ICreateSlidersServices CreateSlidersServices { get; }
        IGetDetailsSlidersServices GetDetailsSlidersServices { get; }
        IGetEditSlidersServices GetEditSlidersServices { get; }
        IEditSlidersServices EditSlidersServices { get; }
        IDeleteSlidersServices DeleteSlidersServices { get; }
    }
}