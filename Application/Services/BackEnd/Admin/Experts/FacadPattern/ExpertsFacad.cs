using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using AutoMapper;

namespace Application.Services.BackEnd.Admin.Experts.FacadPattern
{
    public class ExpertsFacad:IExpertsFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public ExpertsFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        
        private IExpertsServices _expertsServices;
        public IExpertsServices ExpertsServices
        {
            get
            {
                return _expertsServices ??= new ExpertsServices(_customDbContext,_mapper);
            }
            set => throw new System.NotImplementedException();
        }
    }
}