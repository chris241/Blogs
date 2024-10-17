using Blogs.Database;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Extension;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using BlogContext dbContext =
            scope.ServiceProvider.GetRequiredService<BlogContext>();

        dbContext.Database.Migrate();
    }
}
