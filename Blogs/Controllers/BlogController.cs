using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public BlogController()
        {
        }
        [HttpGet("{id}")]
        public IActionResult GetBlog(long id)
        {
            return Ok("");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(long id)
        {
            return Ok("");
        }
        [HttpPost]
        public IActionResult AddBlog()
        {
            return Ok("");
        }
        [HttpPut]
        public IActionResult UpdateBlog(long id)
        {
            return Ok("");
        }
    }
}
