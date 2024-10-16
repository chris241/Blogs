using Blogs.Entities;

namespace Blogs.Repositories
{
    public interface IBlogReposiroty
    {
        Task<long> Create(Blog blogs, CancellationToken cancellationToken);
        Task<long> Udpdate(Blog blogs, CancellationToken cancellationToken);
        Task<Blog> Get(long id, CancellationToken cancellationToken);
        Task<long> Delete(long id, CancellationToken cancellationToken);
    }
}
