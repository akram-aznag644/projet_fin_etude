using System.Linq.Expressions;
using projet_fin_etude.Models;

namespace projet_fin_etude.Data.Repository
{
    public interface ICommonRepository<T> where T : class
    {
        Task<T> CreateAsync(T data);
        Task<List<T>> GetRecordsAsync();
        Task<T> GetRecordAsync(int id);
        Task<bool> UpdateAsync(T data);
        Task<bool> DeleteAsync(T data);

        Task<List<T>> GetByFilterDataAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false);
    }
}
