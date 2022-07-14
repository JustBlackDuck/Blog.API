using Blog.Database.Abstractions;

namespace Blog.Database.Repository;

public class PostRepository: BaseRepository<Post>, IPostRepository
{
    public PostRepository(AppDatabaseContext appDbContext) : base(appDbContext)
    {
    }

    public async Task CreatePostAsync(Post item)
    {
        await CreateAsync(item);
        
    }
    
}