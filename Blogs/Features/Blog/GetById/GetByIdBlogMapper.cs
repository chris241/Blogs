using AutoMapper;

namespace Blogs.Features.Blog.GetById;

public class GetByIdBlogMapper : Profile
{
    public GetByIdBlogMapper()
    {
        CreateMap<Entities.Blog, GetByIdBlogResponse>();
        CreateMap<GetByIdBlogResponse,Entities.Blog>();
    }
}