using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_health.Services.Dependencies
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T item);
        Task<T> UpdateAsync(T item);
        Task RemoveAsync(int id);

    }
}
