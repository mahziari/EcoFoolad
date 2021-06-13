using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Factory.Command.EditFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetCreateFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetEditFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetIndexFactory;

namespace Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IFactoryFacad
    {
        IGetIndexFactoryServices GetIndexFactoryServices { get; }
        IGetCreateFactoryServices GetCreateFactoryServices { get; }
        // IGetEditFactoryServices GetEditFactoryServices { get; }
        ICreateFactoryServices CreateFactoryServices { get; }
        // IEditFactoryServices EditFactoryServices { get; }
    }
}