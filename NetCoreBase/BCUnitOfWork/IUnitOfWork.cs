using NetCoreBase.Features.Inventory.Entities;
using NetCoreBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.BCUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Item> repository { get; }
        void Commit();
        Task CommitAsync();
    }
}
