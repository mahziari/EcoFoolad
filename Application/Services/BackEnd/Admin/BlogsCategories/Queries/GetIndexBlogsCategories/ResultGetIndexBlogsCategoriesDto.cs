using System.Collections.Generic;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public class ResultGetIndexBlogsCategoriesDto
    {
        public List<CrmCmsNewsGroups> BlogsCategories { get; set; }
    }
}