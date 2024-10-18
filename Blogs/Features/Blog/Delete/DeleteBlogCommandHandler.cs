using Blogs.Features.Blog.Create;
using Blogs.Repositories;
using MediatR;

namespace Blogs.Features.Blog.Delete;

public class DeleteBlogCommandHandler(IBlogReposiroty _blogReposiroty)
    : IRequestHandler<DeleteBlogCommand, Guid>
{
    public async Task<Guid> Handle(DeleteBlogCommand command, CancellationToken cancellationToken)
    {
        return await _blogReposiroty.Delete(command.id, cancellationToken); ;
    }
}
