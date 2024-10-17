using MediatR;

namespace Blogs.Features.Blog.Create;

public record CreateBlogCommand(string Title, string Description) : IRequest<Guid>;

