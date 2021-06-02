namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs

{
    public class GetEditBlogsDto
    {
        public int NewsId { get; set; }
        public string NewsGroupName { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool? IsVerified { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public int NewsGroupId { get; set; }
        public int Position { get; set; }
    }
}