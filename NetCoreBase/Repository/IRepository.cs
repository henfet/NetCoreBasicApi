using NetCoreBase.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetFilteredAsync(int id);
        Task<T> GetSingleAsync(int id);
    }
}
