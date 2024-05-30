using Microsoft.EntityFrameworkCore.Storage;
using UniversityProject.Infrustructure.Data;
using UniversityProject.Infrustructure.IGenericRepository;

namespace UniversityProject.Infrustructure.GenericRepository;
public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{
    private readonly AppDbContext _context;
    public GenericRepositoryAsync(AppDbContext context)
    {
        _context = context;
    }
    public async Task<T> AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }


    public async Task AddRangeAsync(ICollection<T> entities)
    {
        await _context.Set<T>().AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }


    public IDbContextTransaction BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public void Commit()
    {
        throw new NotImplementedException();
    }
    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRangeAsync(ICollection<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }


    public IQueryable<T> GetTableAsTracking()
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetTableNoTracking()
    {
        throw new NotImplementedException();
    }

    public void RollBack()
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(ICollection<T> entities)
    {
        _context.Set<T>().UpdateRange(entities);
        await _context.SaveChangesAsync();
    }

}
