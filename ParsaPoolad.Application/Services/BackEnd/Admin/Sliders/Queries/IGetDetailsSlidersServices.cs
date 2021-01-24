using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetDetailsSlidersServices
    {
        ResultGetDetailsSlidersServices Execute();
    }

    public class GetDetailsSlidersServices : IGetDetailsSlidersServices
    {
        private readonly IIdentityDataBaseContext _context;
        public GetDetailsSlidersServices(IIdentityDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetDetailsSlidersServices Execute()
        {
            return new ResultGetDetailsSlidersServices
            {

            };
        }
    }



    public class ResultGetDetailsSlidersServices
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
    }
}