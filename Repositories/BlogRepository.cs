using csharp_graphql.Models;

namespace csharp_graphql.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private static List<BlogModel> _blogs;

        public BlogRepository()
        {
            _blogs = new List<BlogModel>()
            {
                new BlogModel()
                {
                    BlogId = 1,
                    BlogTitle = "Blog Title 1",
                    BlogAuthor = "Blog Author 1",
                    BlogContent = "Blog Content 1"
                },
                new BlogModel()
                {
                    BlogId = 2,
                    BlogTitle = "Blog Title 2",
                    BlogAuthor = "Blog Author 2",
                    BlogContent = "Blog Content 2"
                },
                new BlogModel()
                {
                    BlogId = 3,
                    BlogTitle = "Blog Title 3",
                    BlogAuthor = "Blog Author 3",
                    BlogContent = "Blog Content 3"
                }
            };
        }

        public List<BlogModel> GetBlogs()
        {
            return _blogs;
        }

        public void AddBlog(BlogModel blog)
        {
            _blogs.Add(blog);
        }

        public BlogModel GetBlog(int id)
        {
            return _blogs.Where(x => x.BlogId == id).FirstOrDefault()!;
        }
    }
}
