using csharp_graphql.GraphQL;
using csharp_graphql.Repositories;

namespace csharp_graphql;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder
            .Services.AddControllers()
            .AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton<IBlogRepository, BlogRepository>();
        builder
            .Services.AddGraphQLServer()
            .AddQueryType<BlogQuery>()
            .AddMutationType<BlogMutation>()
            .AddSubscriptionType<BlogSubscription>()
            .AddInMemorySubscriptions();

        var app = builder.Build();
        app.MapGraphQL("/");

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
