using System.Linq.Expressions;
using Blog.Database.Base;
using Microsoft.EntityFrameworkCore;

namespace Blog.Database.Repository;

public abstract class BaseRepository<TModel> where TModel: BaseModel
{
    protected readonly AppDatabaseContext AppDbContext;

    protected BaseRepository(AppDatabaseContext appDbContext)
        => AppDbContext = appDbContext;

    public async Task CreateAsync(TModel item)
    {
        await AppDbContext.Set<TModel>().AddAsync(item);

        await AppDbContext.SaveChangesAsync();
    }

    public async Task<TModel> GetOneAsync(Expression<Func<TModel, bool>> predicate)
        => await AppDbContext.Set<TModel>().AsNoTracking().FirstOrDefaultAsync(predicate);

}