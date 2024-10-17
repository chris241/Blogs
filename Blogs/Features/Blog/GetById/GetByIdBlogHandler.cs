using AutoMapper;
using Blogs.Repositories;
using MediatR;

namespace Blogs.Features.Blog.GetById;

public class GetByIdBlogHandler(IBlogReposiroty _blogReposiroty, IMapper _mapper) : IRequestHandler<GetByIdBlogQuery,GetByIdBlogResponse>
{
    public async Task<GetByIdBlogResponse> Handle(GetByIdBlogQuery request, CancellationToken cancellationToken)
    {
        var blog = await _blogReposiroty.Get(request.id, cancellationToken)!;
        return _mapper.Map<GetByIdBlogResponse>(blog);
    }
}