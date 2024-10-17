using Blogs.Database;
using Blogs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Repositories;

public class BlogRepository(BlogContext _context) : IBlogReposiroty
{
    public async Task<Guid> Create(Blog blog, CancellationToken cancellationToken)
    {
        _context.Add(blog);

        await _context.SaveChangesAsync(cancellationToken);

        return blog.Id;
    }

    public Task<Guid> Delete(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public  async Task<Blog> Get(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<Guid> Udpdate(Blog blogs, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
