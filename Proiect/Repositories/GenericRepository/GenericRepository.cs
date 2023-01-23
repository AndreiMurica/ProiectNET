using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models.Base;

namespace Proiect.Repositories.GenericRepository 
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ProiectContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ProiectContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return  await _table.AsNoTracking().ToListAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteAll()
        {
            _table.RemoveRange(_table);
        }

        public TEntity FindById(object id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }

        
        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
        
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


    }
}
