using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auction.Models.Base
{
    public interface IEntityBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long? id);
        Task AddAsynnc(T entity);
        Task DeleteAsync(long? id);
        Task UpdateAsync(T entity, long id);
    }
}
