using Blog.Common.Dto;
using Blog.Core.Abstraction;
using Blog.Database;
using Blog.Database.Abstractions;

namespace Blog.Core;

public class PostService: IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task CreatePost(CreatePostDto postDto)
    {
        var post = new Post
        {
            Heading = postDto.Heading,
            Text = postDto.Text
        };

        await _postRepository.CreatePostAsync(post);
    }
}