namespace  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs
{
    public interface ICreateBlogsServices
    {
        ResultCreateBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto);
    }
}