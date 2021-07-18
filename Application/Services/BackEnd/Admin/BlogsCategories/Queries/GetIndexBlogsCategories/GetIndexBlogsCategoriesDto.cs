using System;
using System.Collections.Generic;
using Domain.Entities.Blogs;

namespace Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public class GetIndexBlogsCategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public bool IsActive { get; set; }
        public string RegisterUserId { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
        public string LocalTime { get; set; }
        public string ImageUrl { get; set; }
    }
}