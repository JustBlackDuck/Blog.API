namespace Blog.Database.Abstractions;

public interface IPostRepository
{
    Task CreatePostAsync(Post item);
}