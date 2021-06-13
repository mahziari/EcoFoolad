using System.Collections.Generic;
using System.Linq;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Factory.Queries.GetIndexFactory
{
    public interface IGetIndexFactoryServices
    {
        List<FactoryDto> GetIndexFactory();
    }
}