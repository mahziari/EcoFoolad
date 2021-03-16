using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetIndexSlidersServices
    {
        ResultGetIndexSlidersServices Execute();
    }
    public class GetIndexSlidersServices : IGetIndexSlidersServices
    {
        private readonly ICustomDbContext _context;
        public GetIndexSlidersServices(ICustomDbContext context)
        {
            _context = context;
        }

        public ResultGetIndexSlidersServices Execute()
        {

            var sliders = _context.Sliders
                .OrderByDescending(s => s.Id)
                .ToList();
            
            return new ResultGetIndexSlidersServices
            {
                Sliders=sliders
            };
        }
    }



    public class ResultGetIndexSlidersServices
    {
        public List<Domain.Entities.Sliders> Sliders { get; set; }

    }
}