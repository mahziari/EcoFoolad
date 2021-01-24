using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetEditSlidersServices
    {
        ResultGetEditSlidersServices Execute();
    }

    public class GetEditSlidersServices : IGetEditSlidersServices
    {
        private readonly IIdentityDataBaseContext _context;
        public GetEditSlidersServices(IIdentityDataBaseContext context)
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