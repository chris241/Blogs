using System.Text.Json.Serialization;

namespace Blogs.Features.Blog.GetList;

public class GetListBlogResponse
{
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    [JsonPropertyName("Description")]
    public string? Description { get; set; }
}
