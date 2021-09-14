using Microsoft.EntityFrameworkCore;
using NetCoreBase.Base;
using NetCoreBase.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MainDataContext _dataContext;
        private readonly DbSet<T> entities;

        public GenericRepository(MainDataContext dataContext)
        {
            this._dataContext = dataContext;
            entities = dataContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await entities.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            T entity = await GetSingleAsync(id);
            entities.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetFilteredAsync(int id)
        {
            return await entities.Where(e => e.Id == id).ToListAsync();
        }

        public async Task<T> GetSingleAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public void UpdateAsync(T entity)
        {
            entities.Update(entity);
        }
    }
}
