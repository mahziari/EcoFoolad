using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsCategoryFrontEndService
    {
        ResultGetProductsCategoryFrontEndDto Execute(string category);
    }

    public class GetProductsCategoryFrontEndService: IGetProductsCategoryFrontEndService
    {
        private readonly IDataBaseContext _context;

        public GetProductsCategoryFrontEndService(IDataBaseContext context)
        {
            _context = context;
        }



        public ResultGetProductsCategoryFrontEndDto Execute(string category)
        {

            return new ResultGetProductsCategoryFrontEndDto
            {
            };
        }
    }

    public class ResultGetProductsCategoryFrontEndDto
    {
        public List<GetProductsCatrgoryDto> ProductsCatrgory { get; set; }
    }


    public class GetProductsCatrgoryDto
    {
        public int NewsId { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsGroupName { get; set; }
        public string en_NewsGroupName { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public string HeadLine { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime PublishDateTime { get; set; }
        // public string PublishDateTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}