using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetEditSlidersServices
    {
        ResultGetEditSlidersServices Execute();
    }

    public class GetEditSlidersServices : IGetEditSlidersServices
    {
        private readonly ICustomDbContext _context;
        public GetEditSlidersServices(ICustomDbContext context)
        {
            _context = context;
        }

        public ResultGetEditSlidersServices Execute()
        {
            return new ResultGetEditSlidersServices
            {

            };
        }
    }



    public class ResultGetEditSlidersServices
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
    }
    
}