using Blogs.Entities;

namespace Blogs.Repositories;

public interface IBlogReposiroty
{
    Task<Guid> Create(Blog blogs, CancellationToken cancellationToken);
    Task<Guid> Udpdate(Blog blogs, CancellationToken cancellationToken);
    Task<Blog> Get(Guid id, CancellationToken cancellationToken);
    Task<Guid> Delete(Guid id, CancellationToken cancellationToken);
}
