using csharp_graphql.Models;
using csharp_graphql.Repositories;

namespace csharp_graphql.GraphQL;

public class BlogQuery
{
    public List<BlogModel> GetBlogs([Service] IBlogRepository blogRepository)
    {
        return blogRepository.GetBlogs();
    }

    public BlogModel GetBlog([Service] IBlogRepository blogRepository, int blogId)
    {
        return blogRepository.GetBlog(blogId);
    }
}
