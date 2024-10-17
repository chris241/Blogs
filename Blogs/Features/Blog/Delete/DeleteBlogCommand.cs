using MediatR;

namespace Blogs.Features.Blog.Delete;

public record DeleteBlogCommand(Guid id) : IRequest<Guid>;
