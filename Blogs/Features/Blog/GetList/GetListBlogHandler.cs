using AutoMapper;
using Blogs.Features.Blog.GetById;
using Blogs.Repositories;
using MediatR;

namespace Blogs.Features.Blog.GetList;

public class GetListBlogHandler(IBlogReposiroty _blogReposiroty, IMapper _mapper) : IRequestHandler<GetListBlogQuery, List<GetListBlogResponse>>
{
    public async Task<List<GetListBlogResponse>> Handle(GetListBlogQuery request, CancellationToken cancellationToken)
    {
        var blogs = await _blogReposiroty.GetAll(cancellationToken)!;
        return _mapper.Map<List<GetListBlogResponse>>(blogs);
    }
}
