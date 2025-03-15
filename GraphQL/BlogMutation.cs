using csharp_graphql.Models;
using csharp_graphql.Repositories;
using HotChocolate.Subscriptions;

namespace csharp_graphql.GraphQL;

public class BlogMutation
{
    /*
     mutation {
      addBlog(blog: {
        blogId: 4,
        blogTitle: "Blog Title 4",
        blogAuthor: "Blog Author 4",
        blogContent: "Blog Content 4",
        isDeleted: false
      }) {
        blogId
        blogTitle
        blogAuthor
        blogContent
        isDeleted
      }
    }
     */
    public async Task<BlogModel> AddBlog([Service] IBlogRepository blogRepository,
        [Service] ITopicEventSender eventSender,
        BlogModel blog)
    {
        blogRepository.AddBlog(blog);

        await eventSender.SendAsync("BlogAdded", blog);

        return blog;
    }
}
