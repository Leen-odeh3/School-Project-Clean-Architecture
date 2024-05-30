
using Microsoft.EntityFrameworkCore.Storage;
using UniversityProject.Infrustructure.IGenericRepository;

namespace UniversityProject.Infrustructure.GenericRepository;
public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{
    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(ICollection<T> entities)
    {
        throw new NotImplementedException();
    }

    public IDbContextTransaction BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public void Commit()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(ICollection<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
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

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeAsync(ICollection<T> entities)
    {
        throw new NotImplementedException();
    }
}
