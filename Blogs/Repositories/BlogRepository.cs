using Blogs.Database;
using Blogs.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Blogs.Repositories;

public class BlogRepository(BlogContext _context) : IBlogReposiroty
{
    public async Task<Guid> Create(Blog blog, CancellationToken cancellationToken)
    {
        try
        {
            _context.Add(blog);

            await _context.SaveChangesAsync(cancellationToken);
            Log.Information($"data {blog.Title}  {blog.Description} inserted" );
            return blog.Id;
        }
        catch (Exception ex)
        {
            Log.Fatal("Error of " ,ex);
            return Guid.Empty;
        }
        
    }

    public async Task<Guid> Delete(Guid id, CancellationToken cancellationToken)
    {
        var blog = await _context.Blogs
              .FirstOrDefaultAsync(b => b.Id == id, cancellationToken);

        if (blog is null)
        {
            throw new ArgumentException($"Book is not foud Id {id}");
        }

        _context.Remove(blog);

        await _context.SaveChangesAsync(cancellationToken);
        return id;
    }

    public  async Task<Blog> Get(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<Guid> Udpdate(Blog blogs, CancellationToken cancellationToken)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            Log.Fatal("Error of ", ex);
            return null;
        }
    }
}
