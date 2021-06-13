using System.Collections.Generic;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Factory.Command.CreateFactory
{
    public class CreateFactoryServices:ICreateFactoryServices
    {
        private ICustomDbContext _customDbContext;
        private IMapper _mapper;
        public CreateFactoryServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public BaseDto<FactoryDto> CreateFactory(FactoryDto factoryDto)
        {
            var data = _mapper.Map<Domain.Entities.Factory.Factory>(factoryDto);
            _customDbContext.Factories.Add(data);
            _customDbContext.SaveChanges();
            return new BaseDto<FactoryDto>
            (
                true,
                new List<string> {"کارخانه با موفقیت ساخته شد"},
                null
            );
        }
    }
}