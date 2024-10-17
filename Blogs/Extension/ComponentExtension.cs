using System.Reflection;

namespace Blogs.Extension;

public static  class ComponentExtension
{
    public static IServiceCollection AddComponent(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(typeof(ComponentExtension).Assembly);
        });
        return services;
    }
}
