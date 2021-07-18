using Domain.Entities.Blogs;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public class GetEditBlogsCategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
        public string ImageUrl { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}