using csharp_graphql.Models;

namespace csharp_graphql.Repositories
{
    public interface IBlogRepository
    {
        List<BlogModel> GetBlogs();
        BlogModel GetBlog(int id);
        void AddBlog(BlogModel blog);
    }
}
