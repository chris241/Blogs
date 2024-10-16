using Blogs.Entities;

namespace Blogs.Repositories;

public class BlogRepository : IBlogReposiroty
{
    public Task<long> Create(Blog blogs, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<long> Delete(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> Get(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<long> Udpdate(Blog blogs, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
