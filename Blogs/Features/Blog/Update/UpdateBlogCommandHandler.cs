using Blogs.Repositories;
using MediatR;

namespace Blogs.Features.Blog.Update;

public class UpdateBlogCommandHandler(IBlogReposiroty _blogReposiroty)
: IRequestHandler<UpdateBlogCommand, Guid>
{
    public async Task<Guid> Handle(UpdateBlogCommand command, CancellationToken cancellationToken)
    {
        var blog = new Entities.Blog()
        {

        };
        return await _blogReposiroty.Udpdate(blog, cancellationToken); 
    }
}
