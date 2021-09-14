using NetCoreBase.DataContext;
using NetCoreBase.Features.Inventory.Entities;
using NetCoreBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.BCUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDataContext _context;
        private readonly IRepository<Item> _mainDataRepository;

        public UnitOfWork(MainDataContext context)
        {
            _context = context;
        }

        public IRepository<Item> repository => _mainDataRepository ?? new GenericRepository<Item>(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
