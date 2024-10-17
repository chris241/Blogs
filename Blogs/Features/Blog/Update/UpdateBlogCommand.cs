
using MediatR;

namespace Blogs.Features.Blog.Update;

public record UpdateBlogCommand(Guid id,string Title, string Description) : IRequest<Guid>;
