using csharp_graphql.GraphQL;
using csharp_graphql.Repositories;

namespace csharp_graphql.Dependencies;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddDependencies(
        this IServiceCollection services,
        WebApplicationBuilder builder
    )
    {
        builder.Services.AddSingleton<IBlogRepository, BlogRepository>();
        builder
            .Services.AddGraphQLServer()
            .AddQueryType<BlogQuery>()
            .AddMutationType<BlogMutation>()
            .AddSubscriptionType<BlogSubscription>()
            .AddInMemorySubscriptions();

        return services;
    }
}
