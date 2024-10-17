using Blogs.Repositories;
using MediatR;

namespace Blogs.Features.Blog.Create;

public class CreateBlogCommandHandler(IBlogReposiroty _blogReposiroty)
    : IRequestHandler<CreateBlogCommand, Guid>
{
    public async Task<Guid> Handle(CreateBlogCommand command, CancellationToken cancellationToken)
    {
        var newblog = new Entities.Blog()
        {
            Title = command.Title,
            Description = command.Description
        };
        return await _blogReposiroty.Create(newblog, cancellationToken); ;
    }
}
