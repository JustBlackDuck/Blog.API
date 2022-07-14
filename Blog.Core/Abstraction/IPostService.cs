using Blog.Common.Dto;

namespace Blog.Core.Abstraction;

public interface IPostService
{
    Task CreatePost(CreatePostDto postDto);
}