using System.Collections.Generic;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public class ResultGetIndexBlogsCategoriesDto
    {
        public List<GetIndexBlogsCategoriesDto> BlogsCategories { get; set; }
    }
}