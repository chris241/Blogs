using AutoMapper;

namespace Blogs.Features.Blog.GetList;

public class GetListBlogMapper : Profile
{
    public GetListBlogMapper()
    {
        CreateMap<Entities.Blog, GetListBlogResponse>();
        CreateMap<GetListBlogResponse, Entities.Blog>();
    }
}
