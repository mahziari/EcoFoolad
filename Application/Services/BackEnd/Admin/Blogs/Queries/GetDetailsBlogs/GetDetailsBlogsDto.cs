namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
    public class GetDetailsBlogsDto
    {
        public string NewsGroupName { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool? IsVerified { get; set; }
        public string NewsBody { get; set; }
        public string HeadLine { get; set; }
        public int Position { get; set; }

    }
}