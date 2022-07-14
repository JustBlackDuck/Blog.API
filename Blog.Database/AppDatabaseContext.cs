using Microsoft.EntityFrameworkCore;

namespace Blog.Database;

public class AppDatabaseContext: DbContext
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDatabaseContext (DbContextOptions<AppDatabaseContext> options): base(options)
    {
        Database.EnsureCreated();
    }
}