using System.Text.Json.Serialization;

namespace Blogs.Features.Blog.GetById;

public class GetByIdBlogResponse
{
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    [JsonPropertyName("Description")]
    public string? Description { get; set; }
}
