using MediatR;

namespace Blogs.Features.Blog.GetById;

public record GetByIdBlogQuery(Guid id): IRequest<GetByIdBlogResponse>;
