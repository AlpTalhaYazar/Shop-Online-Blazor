using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Database;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ShopOnlineDbContext shopOnlineDbContext;

    public GenericRepository(ShopOnlineDbContext shopOnlineDbContext)
    {
        this.shopOnlineDbContext = shopOnlineDbContext;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await this.shopOnlineDbContext.Set<T>().FindAsync(id);

        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var entities = await this.shopOnlineDbContext.Set<T>().ToListAsync();

        return entities;
    }

    public async Task<T> AddAsync(T entity)
    {
        await this.shopOnlineDbContext.AddAsync(entity);
        await this.shopOnlineDbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        this.shopOnlineDbContext.Entry(entity).State = EntityState.Modified;
        await this.shopOnlineDbContext.SaveChangesAsync();

        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        this.shopOnlineDbContext.Remove(entity);

        await this.shopOnlineDbContext.SaveChangesAsync();
    }
}