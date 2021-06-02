using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsDetailsFrontEndService
    {
        ResultGetProductsDetailsFrontEndDto Execute(string name,int pageNumber);
    }

    public class GetProductsDetailsFrontEndService: IGetProductsDetailsFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetProductsDetailsFrontEndService(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }



        public ResultGetProductsDetailsFrontEndDto Execute(string name,int pageNumber)
        {
            var blog = _context.CrmCmsNews
                .Where(b => b.Title == name.Replace("-"," "))
                .Include(b=>b.NewsGroup)
                .Select(b => new GetProductsDetailsDto
                {
                    NewsId=b.NewsId,
                    NewsGroupId=b.NewsGroupId,
                    NewsGroupName = b.NewsGroup.GroupName,
                    en_NewsGroupName = b.NewsGroup.en_GroupName,
                    Title = b.Title,
                    NewsBody=b.NewsBody,
                    NewsSummery=b.NewsSummery,
                    RegisterDatePersian =b.RegisterDate.ToPersianDigitalDateTimeString(),
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine
                }).FirstOrDefault();

            return new ResultGetProductsDetailsFrontEndDto
            {
                Blog = blog,
            };
        }
    }

    public class ResultGetProductsDetailsFrontEndDto
    {
        public GetProductsDetailsDto Blog { get; set; }
    }


    public class GetProductsDetailsDto
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
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}