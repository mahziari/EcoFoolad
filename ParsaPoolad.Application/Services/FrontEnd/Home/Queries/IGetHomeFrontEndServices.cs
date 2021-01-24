using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Home.Queries
{
    public interface IGetHomeFrontEndService
    {
        ResultGetHomeFrontEndDto Execute();
    }

    public class GetHomeFrontEndService : IGetHomeFrontEndService
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public GetHomeFrontEndService(IDataBaseContext context,IIdentityDataBaseContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }



        public ResultGetHomeFrontEndDto  Execute()
        {
            var sliders = _parsapooladContext.Sliders.
                Select(s=> new GetSlidersDto
                {
                    Id =s.Id,
                    Type = s.Type,
                    Active = s.Active,
                    Position = s.Position,
                    Url = s.Url
                }).ToList();
            
            
            var blogsGroup = _context.CrmCmsNewsGroups
                .Select(g=>new GetBlogsGroupDto
                {
                    Id = g.NewsGroupId,
                    Name = g.GroupName
                }).ToList();

            
            
            
            
            
            return new ResultGetHomeFrontEndDto
            {
                Sliders = sliders,
                BlogsGroup = blogsGroup,

            };
        }
    }

    public class ResultGetHomeFrontEndDto
    {
        public List<GetSlidersDto> Sliders { get; set; }
        public List<GetBlogsGroupDto> BlogsGroup { get; set; }
    }


    public class GetSlidersDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }
        public string Url { get; set; }
    }
    
    public class GetBlogsGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}