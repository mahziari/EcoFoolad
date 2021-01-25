﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Common.Services;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsFrontEndService
    {
        ResultGetBlogsFrontEndDto Execute(int pageNumber,int pageSize);
    }

    public class GetBlogsFrontEndService : IGetBlogsFrontEndService
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public GetBlogsFrontEndService(IDataBaseContext context,IIdentityDataBaseContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }



        public ResultGetBlogsFrontEndDto Execute(int pageNumber,int pageSize)
        {
            int rowsCount = 0;
            
          
            
            var blogs = _context.CrmCmsNews
                .Include(s=>s.NewsGroup)
                .ToPaged(pageNumber, pageSize, out rowsCount)
                .Where(s=>s.IsVerified)
                .Where(b => b.Position == 0)
                .Select(s=> new GetBlogsDto
                {
                    NewsId =s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.GroupName)
                        .FirstOrDefault(),
                    en_NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.en_GroupName)
                        .FirstOrDefault(),
                    HeadLine=s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    RegisterDatePersian =s.RegisterDate.ToPersianDigitalDateTimeString(),
                    IsVerified = s.IsVerified,
                    Position=s.Position,
                }).ToList();
            
            var blogsFav = _context.CrmCmsNews
                .Include(s=>s.NewsGroup)
                .Where(s=>s.IsVerified)
                .Where(S => S.Position != 0)
                .Select(s=> new GetBlogsDto
                {
                    NewsId =s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.GroupName)
                        .FirstOrDefault(),
                    en_NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.en_GroupName)
                        .FirstOrDefault(),
                    HeadLine=s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    RegisterDatePersian =s.RegisterDate.ToPersianDigitalDateTimeString(),
                    IsVerified = s.IsVerified,
                    Position=s.Position,
                }).ToList();

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();



            return new ResultGetBlogsFrontEndDto
            {
                Blogs = blogs,
                BlogsFav = blogsFav,
                BlogsGroup = blogsGroup,
                RowsCount = rowsCount,
            };
        }
    }

    public class ResultGetBlogsFrontEndDto
    {
        public List<GetBlogsDto> Blogs { get; set; }
        public List<GetBlogsDto> BlogsFav { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
        public int RowsCount { get; set; }
    }


    public class GetBlogsDto
    {
        public int NewsId { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsGroupName { get; set; }
        public string en_NewsGroupName { get; set; }
        public string NewsSummery { get; set; }
        public string HeadLine { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}