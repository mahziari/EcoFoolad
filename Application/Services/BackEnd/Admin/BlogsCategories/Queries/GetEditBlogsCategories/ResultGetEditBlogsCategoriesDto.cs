namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public class ResultGetEditBlogsCategoriesDto
    {
        public GetEditBlogsCategoriesDto BlogCategories { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
        public string Image { get; set; }

    }
}