using Blog.Common.Dto;
using Blog.Core.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController: ControllerBase
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePost(CreatePostDto postDto)
    {
        await _postService.CreatePost(postDto);
        return Ok();
    }
}