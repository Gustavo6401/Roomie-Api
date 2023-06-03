using Microsoft.EntityFrameworkCore;
using Roomie_API.Contexto;
using Roomie_API.Interfaces.Repositories.Base;

namespace Roomie_API.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RoomieContext _context;

        public Repository(RoomieContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Modify(entity);

            await _context.SaveChangesAsync();
        }
    }
}
