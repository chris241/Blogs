

using Blogs.Entities;
using Blogs.Repositories;
using Moq;

namespace BlogTest;

public class BlogRepositoryTests
{
    private readonly Mock<IBlogReposiroty> _blogRepositoryMock;
    private readonly CancellationToken _cancellationToken;

    public BlogRepositoryTests()
    {
        _blogRepositoryMock = new Mock<IBlogReposiroty>();
        _cancellationToken = new CancellationToken();
    }

    [Fact]
    public async Task Create_ShouldReturnGuid_WhenBlogIsCreated()
    {
        
        var blog = new Blog { Title ="test", Description="test" };
        var blogId = Guid.NewGuid();
        _blogRepositoryMock.Setup(repo => repo.Create(blog, _cancellationToken)).ReturnsAsync(blogId);

        
        var result = await _blogRepositoryMock.Object.Create(blog, _cancellationToken);

        
        Assert.Equal(blogId, result);
    }

    [Fact]
    public async Task Update_ShouldReturnGuid_WhenBlogIsUpdated()
    {

        var blog = new Blog { Title = "test", Description = "test" };
        var blogId = Guid.NewGuid();
        _blogRepositoryMock.Setup(repo => repo.Udpdate(blog, _cancellationToken)).ReturnsAsync(blogId);

     
        var result = await _blogRepositoryMock.Object.Udpdate(blog, _cancellationToken);

      
        Assert.Equal(blogId, result);
    }

    [Fact]
    public async Task Get_ShouldReturnBlog_WhenIdIsProvided()
    {
        
        var blogId = Guid.NewGuid();
        var blog = new Blog { Title = "test", Description = "test" };
        _blogRepositoryMock.Setup(repo => repo.Get(blogId, _cancellationToken)).ReturnsAsync(blog);

        
        var result = await _blogRepositoryMock.Object.Get(blogId, _cancellationToken);

        
        Assert.Equal(blog, result);
    }

    [Fact]
    public async Task Delete_ShouldReturnGuid_WhenBlogIsDeleted()
    {
        
        var blogId = Guid.NewGuid();
        _blogRepositoryMock.Setup(repo => repo.Delete(blogId, _cancellationToken)).ReturnsAsync(blogId);

      
        var result = await _blogRepositoryMock.Object.Delete(blogId, _cancellationToken);

  
        Assert.Equal(blogId, result);
    }
}