using csharp_graphql.Models;

namespace csharp_graphql.GraphQL
{
    public class BlogSubscription
    {
        /*
         subscription {
          onBlogAdded {
            blogId
            blogTitle
            blogAuthor
            blogContent
            isDeleted
          }
        }
        */
        [Subscribe]
        [Topic("BlogAdded")]
        public BlogModel OnBlogAdded([EventMessage] BlogModel blog) => blog;
    }
}
