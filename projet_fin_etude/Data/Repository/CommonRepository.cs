using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using projet_fin_etude.Models;

namespace projet_fin_etude.Data.Repository
{
    public class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        private readonly MyAppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public CommonRepository(MyAppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> CreateAsync(T data)
        {
            await _dbSet.AddAsync(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteAsync(T data)
        {
            if (data == null)
                return false;

            _dbSet.Remove(data);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task< List<T> > GetByFilterDataAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false)
        {
            return await _dbSet.Where(filter).ToListAsync();
            
        }

        public async Task<T> GetRecordAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetRecordsAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<bool> UpdateAsync(T data)
        {
            if (data == null)
                return false;

            _dbSet.Update(data);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
