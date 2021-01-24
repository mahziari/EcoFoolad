using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetCreateSlidersServices
    {
        ResultGetCreateSlidersServices Execute();
    }

    public class GetCreateSlidersServices : IGetCreateSlidersServices
    {
        private readonly IIdentityDataBaseContext _context;
        public GetCreateSlidersServices(IIdentityDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetCreateSlidersServices Execute()
        {
            var positions = new postionsDto
                {
                    Id = 2
                };

            return new ResultGetCreateSlidersServices
            {
                Positions = positions,
            };
        }
    }

    public class ResultGetCreateSlidersServices
    {
        public postionsDto Positions { get; set; }
        public int Position { get; set; }
        public IFormFile Images { get; set; }
    }

    public class postionsDto
    {
        public int Id { get; set; }
    }
}