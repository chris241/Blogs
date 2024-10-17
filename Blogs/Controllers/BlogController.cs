using Blogs.Contracts;
using Blogs.Features.Blog.Create;
using Blogs.Features.Blog.Delete;
using Blogs.Features.Blog.GetById;
using Blogs.Features.Blog.GetList;
using Blogs.Features.Blog.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ISender _sender;
        public BlogController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _sender.Send(new GetListBlogQuery());
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(Guid id)
        {
            var response =  await _sender.Send(new GetByIdBlogQuery(id));
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async  Task<IActionResult> DeleteBlog(Guid id)
        {
            var response = await _sender.Send(new DeleteBlogCommand(id));
            return Ok(response);
        }
        [HttpPost]
        public async  Task<IActionResult> AddBlog([FromBody] CreateBlogRequest request)
        {
            var response = await _sender.Send(new CreateBlogCommand(request.Title!, request.Description!));
            return Ok(response);
        }
        [HttpPut]
        public IActionResult UpdateBlog([FromBody] UpdateBlogRequest request, Guid id)
        {
            var response = _sender.Send(new UpdateBlogCommand(id, request.Title!
                , request.Description!));
            return Ok(response);
        }
    }
}
