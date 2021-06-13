using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using AutoMapper;

namespace Application.Services.BackEnd.Admin.Factory.Queries.GetIndexFactory
{
    public class GetIndexFactoryServices:IGetIndexFactoryServices{
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public GetIndexFactoryServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        
        public List<FactoryDto> GetIndexFactory()
        {
            var model = _customDbContext.Factories.ToList();
            var data = _mapper.Map<List<FactoryDto>>(model);
            return data;
        }
    }
}