

using Blogs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Database;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options)
    : base(options)
    {
    }
    public DbSet<Blog> Blogs { get; set; }
}