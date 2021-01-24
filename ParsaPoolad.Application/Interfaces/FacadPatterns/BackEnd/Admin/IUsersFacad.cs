using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Commands;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IUsersFacad
    {
        
        IGetIndexUsersServices GetIndexUsersServices { get; }
        // IGetCreateUsersServices GetCreateUsersServices { get; }
        // ICreateUsersServices CreateUsersServices { get; }
        // IGetDetailsUsersServices GetDetailsUsersServices { get; }
        IGetEditUsersServices GetEditUsersServices { get; }
        IEditUsersServices EditUsersServices { get; }
        // IDeleteUsersServices DeleteUsersServices { get; }
        // IActiveUsersServices ActiveUsersServices { get; }

    }
}