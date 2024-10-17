using MediatR;

namespace Blogs.Features.Blog.GetList;

public record GetListBlogQuery() : IRequest<List<GetListBlogResponse>>;
